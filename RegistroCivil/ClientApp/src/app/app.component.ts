import { Component,  } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';
  hidden!:boolean;

  constructor(public router:Router){}

  ngOnInit(){
    this.router.events.subscribe(event => {
      if (event instanceof NavigationEnd) {
        if (event.url === '/') {
          this.hidden =true ;
        } else {
          this.hidden = false;
        }
      }
    });
  }
}


