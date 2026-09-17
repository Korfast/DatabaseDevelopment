# Project Context

## Current State

- Проект: `VideoHostingApp`, учебное Windows Forms приложение по разработке базы данных.
- В корне есть чек-листы проверки: `program_verification_checklist.md` и `lab3_verification_checklist.md`.
- Для истории изменений используется `CHANGELOG.md`.
- Для итогов отдельных рабочих сессий используется папка `docs/sessions/`.

## Current Focus

- Вести проверяемую историю изменений и решений по проекту.
- После рабочих сессий сохранять краткие итоги, выполненные проверки и следующие шаги.
- Для сохранения итогов сессии используется команда `/save_session_data`.

## Open Questions

- Уточнить, какие изменения считать версией/этапом сдачи и когда переносить записи из `Unreleased` в отдельный релизный раздел.

## Next Steps

- При команде `/save_session_data` создать файл `docs/sessions/YYYY-MM-DD-NN.md`.
- Если в сессии были значимые изменения, обновить `CHANGELOG.md`.
- Если выполнялась проверка программы, обновить `program_verification_checklist.md`.
