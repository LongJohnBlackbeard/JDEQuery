using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15011B - .
/// </summary>
public class F15011B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NKDOCO.
        /// </summary>
        public const string NKDOCO = "NKDOCO";

        /// <summary>
        /// NKBCI.
        /// </summary>
        public const string NKBCI = "NKBCI";

        /// <summary>
        /// NKGENT.
        /// </summary>
        public const string NKGENT = "NKGENT";

        /// <summary>
        /// NKCTRY.
        /// </summary>
        public const string NKCTRY = "NKCTRY";

        /// <summary>
        /// NKYR.
        /// </summary>
        public const string NKYR = "NKYR";

        /// <summary>
        /// NKBF01.
        /// </summary>
        public const string NKBF01 = "NKBF01";

        /// <summary>
        /// NKBF02.
        /// </summary>
        public const string NKBF02 = "NKBF02";

        /// <summary>
        /// NKBF03.
        /// </summary>
        public const string NKBF03 = "NKBF03";

        /// <summary>
        /// NKBF04.
        /// </summary>
        public const string NKBF04 = "NKBF04";

        /// <summary>
        /// NKBF05.
        /// </summary>
        public const string NKBF05 = "NKBF05";

        /// <summary>
        /// NKBF06.
        /// </summary>
        public const string NKBF06 = "NKBF06";

        /// <summary>
        /// NKBF07.
        /// </summary>
        public const string NKBF07 = "NKBF07";

        /// <summary>
        /// NKBF08.
        /// </summary>
        public const string NKBF08 = "NKBF08";

        /// <summary>
        /// NKBF09.
        /// </summary>
        public const string NKBF09 = "NKBF09";

        /// <summary>
        /// NKBF10.
        /// </summary>
        public const string NKBF10 = "NKBF10";

        /// <summary>
        /// NKBF11.
        /// </summary>
        public const string NKBF11 = "NKBF11";

        /// <summary>
        /// NKBF12.
        /// </summary>
        public const string NKBF12 = "NKBF12";

        /// <summary>
        /// NKBF13.
        /// </summary>
        public const string NKBF13 = "NKBF13";

        /// <summary>
        /// NKBF14.
        /// </summary>
        public const string NKBF14 = "NKBF14";

        /// <summary>
        /// NKBF15.
        /// </summary>
        public const string NKBF15 = "NKBF15";

        /// <summary>
        /// NKBF16.
        /// </summary>
        public const string NKBF16 = "NKBF16";

        /// <summary>
        /// NKBF17.
        /// </summary>
        public const string NKBF17 = "NKBF17";

        /// <summary>
        /// NKBF18.
        /// </summary>
        public const string NKBF18 = "NKBF18";

        /// <summary>
        /// NKBF19.
        /// </summary>
        public const string NKBF19 = "NKBF19";

        /// <summary>
        /// NKBF20.
        /// </summary>
        public const string NKBF20 = "NKBF20";

        /// <summary>
        /// NKBF21.
        /// </summary>
        public const string NKBF21 = "NKBF21";

        /// <summary>
        /// NKBF22.
        /// </summary>
        public const string NKBF22 = "NKBF22";

        /// <summary>
        /// NKBF23.
        /// </summary>
        public const string NKBF23 = "NKBF23";

        /// <summary>
        /// NKBF24.
        /// </summary>
        public const string NKBF24 = "NKBF24";

        /// <summary>
        /// NKBF25.
        /// </summary>
        public const string NKBF25 = "NKBF25";

        /// <summary>
        /// NKBF26.
        /// </summary>
        public const string NKBF26 = "NKBF26";

        /// <summary>
        /// NKBF27.
        /// </summary>
        public const string NKBF27 = "NKBF27";

        /// <summary>
        /// NKBF28.
        /// </summary>
        public const string NKBF28 = "NKBF28";

        /// <summary>
        /// NKBF29.
        /// </summary>
        public const string NKBF29 = "NKBF29";

        /// <summary>
        /// NKBF30.
        /// </summary>
        public const string NKBF30 = "NKBF30";

        /// <summary>
        /// NKBF31.
        /// </summary>
        public const string NKBF31 = "NKBF31";

        /// <summary>
        /// NKBF32.
        /// </summary>
        public const string NKBF32 = "NKBF32";

        /// <summary>
        /// NKBF33.
        /// </summary>
        public const string NKBF33 = "NKBF33";

        /// <summary>
        /// NKBF34.
        /// </summary>
        public const string NKBF34 = "NKBF34";

        /// <summary>
        /// NKBF35.
        /// </summary>
        public const string NKBF35 = "NKBF35";

        /// <summary>
        /// NKBF36.
        /// </summary>
        public const string NKBF36 = "NKBF36";

        /// <summary>
        /// NKBF37.
        /// </summary>
        public const string NKBF37 = "NKBF37";

        /// <summary>
        /// NKBF38.
        /// </summary>
        public const string NKBF38 = "NKBF38";

        /// <summary>
        /// NKBF39.
        /// </summary>
        public const string NKBF39 = "NKBF39";

        /// <summary>
        /// NKBF40.
        /// </summary>
        public const string NKBF40 = "NKBF40";

        /// <summary>
        /// NKBF41.
        /// </summary>
        public const string NKBF41 = "NKBF41";

        /// <summary>
        /// NKBF42.
        /// </summary>
        public const string NKBF42 = "NKBF42";

        /// <summary>
        /// NKBF43.
        /// </summary>
        public const string NKBF43 = "NKBF43";

        /// <summary>
        /// NKBF44.
        /// </summary>
        public const string NKBF44 = "NKBF44";

        /// <summary>
        /// NKBF45.
        /// </summary>
        public const string NKBF45 = "NKBF45";

        /// <summary>
        /// NKBF46.
        /// </summary>
        public const string NKBF46 = "NKBF46";

        /// <summary>
        /// NKBF47.
        /// </summary>
        public const string NKBF47 = "NKBF47";

        /// <summary>
        /// NKBF48.
        /// </summary>
        public const string NKBF48 = "NKBF48";

        /// <summary>
        /// NKBF49.
        /// </summary>
        public const string NKBF49 = "NKBF49";

        /// <summary>
        /// NKBF50.
        /// </summary>
        public const string NKBF50 = "NKBF50";

        /// <summary>
        /// NKBF51.
        /// </summary>
        public const string NKBF51 = "NKBF51";

        /// <summary>
        /// NKBF52.
        /// </summary>
        public const string NKBF52 = "NKBF52";

        /// <summary>
        /// NKBF53.
        /// </summary>
        public const string NKBF53 = "NKBF53";

        /// <summary>
        /// NKBF54.
        /// </summary>
        public const string NKBF54 = "NKBF54";

        /// <summary>
        /// NKBCI3.
        /// </summary>
        public const string NKBCI3 = "NKBCI3";

        /// <summary>
        /// NKLSVR.
        /// </summary>
        public const string NKLSVR = "NKLSVR";

        /// <summary>
        /// NKURCD.
        /// </summary>
        public const string NKURCD = "NKURCD";

        /// <summary>
        /// NKURDT.
        /// </summary>
        public const string NKURDT = "NKURDT";

        /// <summary>
        /// NKURAT.
        /// </summary>
        public const string NKURAT = "NKURAT";

        /// <summary>
        /// NKURAB.
        /// </summary>
        public const string NKURAB = "NKURAB";

        /// <summary>
        /// NKURRF.
        /// </summary>
        public const string NKURRF = "NKURRF";

        /// <summary>
        /// NKUSER.
        /// </summary>
        public const string NKUSER = "NKUSER";

        /// <summary>
        /// NKPID.
        /// </summary>
        public const string NKPID = "NKPID";

        /// <summary>
        /// NKUPMJ.
        /// </summary>
        public const string NKUPMJ = "NKUPMJ";

        /// <summary>
        /// NKUPMT.
        /// </summary>
        public const string NKUPMT = "NKUPMT";

        /// <summary>
        /// NKJOBN.
        /// </summary>
        public const string NKJOBN = "NKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F15011B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NKDOCO", "NKDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NKBCI", "NKBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NKGENT", "NKGENT", JdeDataType.String, 2, true, true),
        new JdeField("NKCTRY", "NKCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("NKYR", "NKYR", JdeDataType.Numeric, null, true, true),
        new JdeField("NKBF01", "NKBF01", JdeDataType.String, 2),
        new JdeField("NKBF02", "NKBF02", JdeDataType.String, 2),
        new JdeField("NKBF03", "NKBF03", JdeDataType.String, 2),
        new JdeField("NKBF04", "NKBF04", JdeDataType.String, 2),
        new JdeField("NKBF05", "NKBF05", JdeDataType.String, 2),
        new JdeField("NKBF06", "NKBF06", JdeDataType.String, 2),
        new JdeField("NKBF07", "NKBF07", JdeDataType.String, 2),
        new JdeField("NKBF08", "NKBF08", JdeDataType.String, 2),
        new JdeField("NKBF09", "NKBF09", JdeDataType.String, 2),
        new JdeField("NKBF10", "NKBF10", JdeDataType.String, 2),
        new JdeField("NKBF11", "NKBF11", JdeDataType.String, 2),
        new JdeField("NKBF12", "NKBF12", JdeDataType.String, 2),
        new JdeField("NKBF13", "NKBF13", JdeDataType.String, 2),
        new JdeField("NKBF14", "NKBF14", JdeDataType.String, 2),
        new JdeField("NKBF15", "NKBF15", JdeDataType.String, 2),
        new JdeField("NKBF16", "NKBF16", JdeDataType.String, 2),
        new JdeField("NKBF17", "NKBF17", JdeDataType.String, 2),
        new JdeField("NKBF18", "NKBF18", JdeDataType.String, 2),
        new JdeField("NKBF19", "NKBF19", JdeDataType.String, 2),
        new JdeField("NKBF20", "NKBF20", JdeDataType.String, 2),
        new JdeField("NKBF21", "NKBF21", JdeDataType.String, 2),
        new JdeField("NKBF22", "NKBF22", JdeDataType.String, 2),
        new JdeField("NKBF23", "NKBF23", JdeDataType.String, 2),
        new JdeField("NKBF24", "NKBF24", JdeDataType.String, 2),
        new JdeField("NKBF25", "NKBF25", JdeDataType.String, 2),
        new JdeField("NKBF26", "NKBF26", JdeDataType.String, 2),
        new JdeField("NKBF27", "NKBF27", JdeDataType.String, 2),
        new JdeField("NKBF28", "NKBF28", JdeDataType.String, 2),
        new JdeField("NKBF29", "NKBF29", JdeDataType.String, 2),
        new JdeField("NKBF30", "NKBF30", JdeDataType.String, 2),
        new JdeField("NKBF31", "NKBF31", JdeDataType.String, 2),
        new JdeField("NKBF32", "NKBF32", JdeDataType.String, 2),
        new JdeField("NKBF33", "NKBF33", JdeDataType.String, 2),
        new JdeField("NKBF34", "NKBF34", JdeDataType.String, 2),
        new JdeField("NKBF35", "NKBF35", JdeDataType.String, 2),
        new JdeField("NKBF36", "NKBF36", JdeDataType.String, 2),
        new JdeField("NKBF37", "NKBF37", JdeDataType.String, 2),
        new JdeField("NKBF38", "NKBF38", JdeDataType.String, 2),
        new JdeField("NKBF39", "NKBF39", JdeDataType.String, 2),
        new JdeField("NKBF40", "NKBF40", JdeDataType.String, 2),
        new JdeField("NKBF41", "NKBF41", JdeDataType.String, 2),
        new JdeField("NKBF42", "NKBF42", JdeDataType.String, 2),
        new JdeField("NKBF43", "NKBF43", JdeDataType.String, 2),
        new JdeField("NKBF44", "NKBF44", JdeDataType.String, 2),
        new JdeField("NKBF45", "NKBF45", JdeDataType.String, 2),
        new JdeField("NKBF46", "NKBF46", JdeDataType.String, 2),
        new JdeField("NKBF47", "NKBF47", JdeDataType.String, 2),
        new JdeField("NKBF48", "NKBF48", JdeDataType.String, 2),
        new JdeField("NKBF49", "NKBF49", JdeDataType.String, 2),
        new JdeField("NKBF50", "NKBF50", JdeDataType.String, 2),
        new JdeField("NKBF51", "NKBF51", JdeDataType.String, 2),
        new JdeField("NKBF52", "NKBF52", JdeDataType.String, 2),
        new JdeField("NKBF53", "NKBF53", JdeDataType.String, 2),
        new JdeField("NKBF54", "NKBF54", JdeDataType.String, 2),
        new JdeField("NKBCI3", "NKBCI3", JdeDataType.Numeric),
        new JdeField("NKLSVR", "NKLSVR", JdeDataType.Numeric),
        new JdeField("NKURCD", "NKURCD", JdeDataType.String, 4),
        new JdeField("NKURDT", "NKURDT", JdeDataType.Numeric),
        new JdeField("NKURAT", "NKURAT", JdeDataType.Numeric),
        new JdeField("NKURAB", "NKURAB", JdeDataType.Numeric),
        new JdeField("NKURRF", "NKURRF", JdeDataType.String, 30),
        new JdeField("NKUSER", "NKUSER", JdeDataType.String, 20),
        new JdeField("NKPID", "NKPID", JdeDataType.String, 20),
        new JdeField("NKUPMJ", "NKUPMJ", JdeDataType.Numeric),
        new JdeField("NKUPMT", "NKUPMT", JdeDataType.Numeric),
        new JdeField("NKJOBN", "NKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15011B_0", "Primary Key on NKDOCO, NKBCI, NKGENT, NKCTRY, NKYR", new[] { "NKDOCO", "NKBCI", "NKGENT", "NKCTRY", "NKYR" }, isUnique: true, isPrimaryKey: true)
    };
}
