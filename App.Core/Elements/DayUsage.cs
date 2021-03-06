﻿namespace App.Core.Elements
{
    /// <summary>
    /// Класс ля описания ежедневного использования служб облака.
    /// </summary>
    public class DayUsage
    {
        /// <summary>
        /// Дата использования.
        /// </summary>
        /// <remarks>Расчетный период, в течение которого ресурс был израсходован.</remarks>
        public string DateOfUse { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        /// <remarks>Указывает имя использованной службы.</remarks>
        public string Name { get; set; }

        /// <summary>
        /// ResourceGuid.
        /// </summary>
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Тип.
        /// </summary>
        /// <remarks>В некоторых случаях в данном столбце может быть дополнительно уточнен тип службы Windows Azure, что может повлиять на тариф.</remarks>
        public string Type { get; set; }

        /// <summary>
        /// Ресурс.
        /// </summary>
        /// <remarks>Указывает тип израсходованного ресурса. Например, к типам ресурсов относятся часы вычислительных операций, передача данных и транзакции с хранилищем.</remarks>
        public string Resource { get; set; }

        /// <summary>
        /// Регион.
        /// </summary>
        /// <remarks>Указывает расположение центра обработки данных для определенных служб, для которых на основе такого расположения определяется цена (например, передача данных).</remarks>
        public string Region { get; set; }

        /// <summary>
        /// Единица.
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Израсходовано.
        /// </summary>
        /// <remarks>Содержит объем ресурсов, израсходованных за этот день.</remarks>
        public string Spent { get; set; }

        /// <summary>
        /// Субрегион.
        /// </summary>
        /// <remarks>
        /// В тех случаях, когда это уместно и доступно для служб, данный столбец указывает расположение центра обработки данных в регионе. Текущие субрегионы включают в себя следующее:
        ///     * Восточная Азия
        ///     * Юго-Восточная Азия
        ///     * Северная Европа
        ///     * Западная Европа
        ///     * Северо-Центральный регион США
        ///     * Юго-Центральный регион США
        /// </remarks>
        public string SubRegion { get; set; }

        /// <summary>
        /// Служба.
        /// </summary>
        /// <remarks>Этот столбец используется для отслеживания отдельной службы платформы Windows Azure, которая может быть не указана отдельно в столбце имени. Например, передача данных в столбце имени указывается как "Платформа Windows Azure — все службы". Этот столбец службы указывает, к какой именно службе относится данное использование.</remarks>
        public string Service { get; set; }

        /// <summary>
        /// Компонент.
        /// </summary>
        /// <remarks>Когда это возможно, данный столбец указывает компонент, связанный с расходуемым ресурсом. Например, для размещенных служб вычислений в этом столбце отображается имя размещенной службы, к которой относится данное использование, а в квадратных скобках указывается метка, указанная вами для рабочих или промежуточных сред. Для баз данных, учетных записей хранения и других ресурсов в нем обычно отображается имя, указанное вами для таких ресурсов при их создании.</remarks>
        public string Component { get; set; }

        /// <summary>
        /// Сведения о службе 1.
        /// </summary>
        /// <remarks>
        /// В настоящее время этот столбец используется для указания предоставленного размера кэша или типа виртуальной машины.
        ///     * 128 МБ памяти кэша на 1 день
        ///     * 256 МБ памяти кэша на 1 день
        ///     * 512 МБ памяти кэша на 1 день
        ///     * 1024 МБ памяти кэша на 1 день
        ///     * 2048 МБ памяти кэша на 1 день
        ///     * 4096 МБ памяти кэша на 1 день
        /// Кроме того, в нем может содержаться информация об используемом домене для веб-сайта.
        /// </remarks>
        public string ServiceInfo1 { get; set; }

        /// <summary>
        /// Сведения о службе 2.
        /// </summary>
        /// <remarks>Этот столбец зарезервирован для будущего использования.</remarks>
        public string ServiceInfo2 { get; set; }

        /// <summary>
        /// Дополнительная информация.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Инициализация "пустого" объекта.
        /// </summary>
        public DayUsage()
        { }

        /// <summary>
        /// Инициализация объекта с данными, полученными при разборе строки файла CSV.
        /// </summary>
        /// <param name="data">Массив строк с данными из разобранной строки.</param>
        public DayUsage(string[] data)
        {
            DateOfUse = data[0];
            Name = data[1];
            ResourceGuid = data[2];
            Type = data[3];
            Resource = data[4];
            Region = data[5];
            Unit = data[6];
            Spent = data[7];
            SubRegion = data[8];
            Service = data[9];
            Component = data[10];
            ServiceInfo1 = data[11];
            ServiceInfo2 = data[12];
            AdditionalInfo = data[13];
        }
    }
}
