import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { EditComponent } from './components/employee-edit/employee-edit.component';
import { NewComponent } from './components/employee-new/employee-new.component';
import { DetailsComponent } from './components/employee-detail/employee-detail.component';
import { EmployeeService } from './services/employee-service';

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        EditComponent,
        NewComponent,
        DetailsComponent
    ],
    providers: [EmployeeService],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'details/:id', component: DetailsComponent },
            { path: 'new', component: NewComponent },
            { path: 'edit/:id', component: EditComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModule {
}
