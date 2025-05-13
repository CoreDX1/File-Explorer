import { Component } from '@angular/core';
import { CommonModule } from '@angular/common'; // Needed for *ngIf, *ngFor
import { FormsModule } from '@angular/forms'; // <--- Import FormsModule HERE

// Interface FileItem definition (as before)
interface FileItem {
  name: string;
  type: 'folder' | 'file';
  modified: string;
  size?: string;
}

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './app.component.html',
})
export class AppComponent {
  searchQuery: string = '';
  showNewFolderModal: boolean = false;
  newFolderName: string = '';

  mockFiles: FileItem[] = [];

  get filteredFiles(): FileItem[] {
    // ... filter logic
    if (!this.searchQuery) {
      return this.mockFiles;
    }
    const lowerQuery = this.searchQuery.toLowerCase();
    return this.mockFiles.filter((file) =>
      file.name.toLowerCase().includes(lowerQuery)
    );
  }

  openNewFolderModal(): void {
    this.showNewFolderModal = true;
  }

  closeNewFolderModal(): void {
    this.showNewFolderModal = false;
    this.newFolderName = '';
  }

  createFolder(): void {
    if (!this.newFolderName.trim()) {
      alert('Please enter a folder name.');
      return;
    }
    const newFolder: FileItem = {
      name: this.newFolderName.trim(),
      type: 'folder',
      modified: 'Just now',
    };
    this.mockFiles.unshift(newFolder);
    console.log('Creating folder:', this.newFolderName);
    this.closeNewFolderModal();
  }

  trackByFileName(index: number, item: FileItem): string {
    return item.name;
  }

  // ... other placeholder methods
  uploadFiles(): void {
    console.log('Upload');
  }
  downloadFiles(): void {
    console.log('Download');
  }
  createNewFile(): void {
    console.log('New File');
  }
  openSettings(): void {
    console.log('Settings');
  }
  navigateToMyFiles(): void {
    console.log('My Files');
  }
}
