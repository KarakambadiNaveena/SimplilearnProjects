import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-assign4',
  templateUrl: './assign4.component.html',
  styleUrls: ['./assign4.component.css']
})
export class Assign4Component implements OnInit {
  movieslist :any[]= [
    {name :"Bahubali"},
    {name:"Titanic"},
    {name :"Life is Beautiful"},
    {name :"Happy Days"},
    {name :"Friends"}
  ];
  constructor() { }

  ngOnInit(): void {
  }

}
