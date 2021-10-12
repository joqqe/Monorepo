import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ItemServiceService } from './item-service.service';

export interface TodoItem {
  id: string;
  title: string;
  content: string;
  urgencyLevel: number;
  deadline: string;
  isDone: boolean;
}
@Component({
  selector: 'inetum-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None,
})
export class AppComponent implements OnInit {
  items: any;
  item = {
    title:  '',
    content: '',
    urgencyLevel: 0,
    deadline: '',
    isDone: false
} 
  title = 'todo-app';
  constructor(public todoApi: ItemServiceService){  }
  ngOnInit() {
    this.updateItemsList();
   }
   updateItemsList(){
    this.todoApi.getTodoItems().subscribe((data: any) => {
      this.items = data
    });
   }
   addItem() {
    this.todoApi.createTodoItem(this.item).subscribe((data: any) => {
      this.updateItemsList();
    });
   }
}
