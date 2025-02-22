import { bootstrapApplication } from "@angular/platform-browser";
import { appConfig } from "@app/app.config";
import { AppComponent } from "@app/app.component";

bootstrapApplication(AppComponent, appConfig).catch((err) => {
  // @todo, add the correct behaviour
  console.error(err);
});
