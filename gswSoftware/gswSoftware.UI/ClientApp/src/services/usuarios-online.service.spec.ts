import { TestBed } from '@angular/core/testing';

import { UsuariosOnlineService } from './usuarios-online.service';

describe('UsuariosOnlineService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: UsuariosOnlineService = TestBed.get(UsuariosOnlineService);
    expect(service).toBeTruthy();
  });
});
