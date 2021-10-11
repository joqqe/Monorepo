import { Component, ViewEncapsulation } from '@angular/core';
import { Item } from './item';
@Component({
  selector: 'inetum-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None,
})
export class AppComponent {
  title = 'todo-app';
  items = [];
}
