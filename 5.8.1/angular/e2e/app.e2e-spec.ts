import { MyEmployeeTemplatePage } from './app.po';

describe('MyEmployee App', function() {
  let page: MyEmployeeTemplatePage;

  beforeEach(() => {
    page = new MyEmployeeTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
