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
  item = {
    "id": "856c5cbf-5a3e-4322-ab8f-251e504ee946",
    "title": "stofzuigen2",
    "content": "voor manu",
    "urgencyLevel": 2,
    "deadline": "2021-10-11T16:26:49.8810673+02:00",
    "isDone": false
} 
  title = 'todo-app';
  constructor(public todoApi: ItemServiceService){  }
  ngOnInit() {
    this.todoApi.createTodoItem(this.item).subscribe((data: {}) => {
      console.log(data)
    })
    this.todoApi.getTodoItems().subscribe((data: any) => {
      console.log(data);
    });
    
   }
}
