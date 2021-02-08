import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/models/Category';
import { CategoryService } from 'src/app/services/category.service';

@Component({
  selector: 'app-home-category',
  templateUrl: './home-category.component.html',
  styleUrls: ['./home-category.component.css'],
})
export class HomeCategoryComponent implements OnInit {
  constructor(private categoryService: CategoryService) {}

  categories: Category[];
  cateDropdownClass: string;

  ngOnInit(): void {
    this.getCategories(true);
    this.cateDropdownClass = 'cate-dropdown show';
  }
  getCategories(isMain: boolean) {
    this.categoryService.getCategories(isMain).subscribe((data) => {
      this.categories = data;
    });
  }
  categoryClick() {
    if (this.cateDropdownClass === 'cate-dropdown')
      this.cateDropdownClass = 'cate-dropdown show';
    else this.cateDropdownClass = 'cate-dropdown';
  }
  subCategoryClick(i: number): void {
    var element = document.getElementsByClassName('subcate-drowdown')[i];
    if (element.classList.contains('show')) element.classList.remove('show');
    else element.classList.add('show');
  }
}