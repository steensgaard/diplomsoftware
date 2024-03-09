# Præsentation af genstandsområdet
Mange har oplevet at sidde og vente, mens "computeren tænker", eller har oplevet ikke at kunne komme ind på en hjemmeside, fordi den aldrig dukkede op. Hvordan sikrer man, at disse scenarier ikke finder sted?

Performance- og Load-testing hører til i den fjerde kvadrant af "Agile Testing Quadrants" (side 98 i Agile Testing-bogen) og befinder sig dermed i skæringspunktet mellem Technology-Facing og Critique Product. Det vil sige, at der er tale om tests, der udfordrer produktets tekniske kvalitet, uden nødvendigvis at verificere produktets korrekthed, altså såkaldte non-funktionelle tests. Men hvilke slags performance tests bliver brugt i industrien til kvalitetssikring?

Gode intentioner er dog ikke nok, så selvom det teknisk er muligt at teste for performance, skal denne mulighed også indarbejdes i de processer, som det agile team bruger. Ifølge [simpletester.co.uk](https://simpletester.co.uk/open-source-testing-the-2020-survey) svarer omkring 60% af de adspurgte, at performance tests bliver udført i deres organisation. Spørgsmålet melder sig således: hvordan kan man indarbejde performance testing i et agilt team, således at man ikke ender som de 40%, der ikke benytter performance testing i organisationen?

# Problemformulering

* Hvordan defineres performance testning og hvad evaluerer de forskellige metoder?

* Hvordan kan man indarbejde performance testning som en del af den agile udviklings process?
    * Hvordan udformes quality gates med hensyn til performance testing. 
    * Hvordan kan performance testning indplementeres i ci/cd pipeline

# Performance test
## Load testing
## Stress testing
## Soak testing/Endurance testing
## Spike testing
## Breakpoint testing

# ci/cd pipeline
## Opsætning af kvalitets gates
Hvad er best practice på områden, prøver man at opsamle data løbende og validere at systemet ikke forringes over tid eller sætter man statiske målsætninger som en hård gærnse der ikke må krydses? 
## ci/cd implementation
Konseptuel eksempel på implementeringen i en pipeline


# Konklusion
