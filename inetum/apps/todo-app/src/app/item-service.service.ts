import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

export interface TodoItem {
  id: string;
  title: string;
  content: string;
  urgencyLevel: number;
  deadline: string;
  isDone: boolean;
}
export interface PostTodoItem {
  title: string;
  content: string;
  urgencyLevel: number;
  deadline: string;
  isDone: boolean;
}


@Injectable({
  providedIn: 'root'
})
export class ItemServiceService {

  apiBaseUrl = 'https://localhost:44312/api/';
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }  

  constructor(private http: HttpClient) { }

  getTodoItems(): Observable<TodoItem> {
    return this.http.get<TodoItem>(this.apiBaseUrl+ 'Todo')
    .pipe(
      retry(1),
      catchError(this.handleError)
    )
  }

  createTodoItem(item: PostTodoItem): Observable<TodoItem> {
    return this.http.post<TodoItem>('https://localhost:44312/api/Todo', JSON.stringify(item), this.httpOptions)
    .pipe(
      catchError(this.handleError)
    )
  }  


  handleError(error:any) {
    let errorMessage = '';
    if(error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    window.alert(errorMessage);
    return throwError(errorMessage);
 }
}
