using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15020 - .
/// </summary>
public class F15020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NNDOCO.
        /// </summary>
        public const string NNDOCO = "NNDOCO";

        /// <summary>
        /// NNBCI.
        /// </summary>
        public const string NNBCI = "NNBCI";

        /// <summary>
        /// NNBLFC.
        /// </summary>
        public const string NNBLFC = "NNBLFC";

        /// <summary>
        /// NNGENT.
        /// </summary>
        public const string NNGENT = "NNGENT";

        /// <summary>
        /// NNSUSP.
        /// </summary>
        public const string NNSUSP = "NNSUSP";

        /// <summary>
        /// NNSUDT.
        /// </summary>
        public const string NNSUDT = "NNSUDT";

        /// <summary>
        /// NNBF14.
        /// </summary>
        public const string NNBF14 = "NNBF14";

        /// <summary>
        /// NNBF15.
        /// </summary>
        public const string NNBF15 = "NNBF15";

        /// <summary>
        /// NNBF16.
        /// </summary>
        public const string NNBF16 = "NNBF16";

        /// <summary>
        /// NNBF17.
        /// </summary>
        public const string NNBF17 = "NNBF17";

        /// <summary>
        /// NNBF18.
        /// </summary>
        public const string NNBF18 = "NNBF18";

        /// <summary>
        /// NNBF19.
        /// </summary>
        public const string NNBF19 = "NNBF19";

        /// <summary>
        /// NNBF20.
        /// </summary>
        public const string NNBF20 = "NNBF20";

        /// <summary>
        /// NNBF21.
        /// </summary>
        public const string NNBF21 = "NNBF21";

        /// <summary>
        /// NNBF22.
        /// </summary>
        public const string NNBF22 = "NNBF22";

        /// <summary>
        /// NNBF23.
        /// </summary>
        public const string NNBF23 = "NNBF23";

        /// <summary>
        /// NNBF24.
        /// </summary>
        public const string NNBF24 = "NNBF24";

        /// <summary>
        /// NNBF25.
        /// </summary>
        public const string NNBF25 = "NNBF25";

        /// <summary>
        /// NNBF26.
        /// </summary>
        public const string NNBF26 = "NNBF26";

        /// <summary>
        /// NNBF27.
        /// </summary>
        public const string NNBF27 = "NNBF27";

        /// <summary>
        /// NNBF28.
        /// </summary>
        public const string NNBF28 = "NNBF28";

        /// <summary>
        /// NNBF29.
        /// </summary>
        public const string NNBF29 = "NNBF29";

        /// <summary>
        /// NNBF30.
        /// </summary>
        public const string NNBF30 = "NNBF30";

        /// <summary>
        /// NNBF31.
        /// </summary>
        public const string NNBF31 = "NNBF31";

        /// <summary>
        /// NNBF32.
        /// </summary>
        public const string NNBF32 = "NNBF32";

        /// <summary>
        /// NNBF33.
        /// </summary>
        public const string NNBF33 = "NNBF33";

        /// <summary>
        /// NNBF34.
        /// </summary>
        public const string NNBF34 = "NNBF34";

        /// <summary>
        /// NNBF35.
        /// </summary>
        public const string NNBF35 = "NNBF35";

        /// <summary>
        /// NNBF36.
        /// </summary>
        public const string NNBF36 = "NNBF36";

        /// <summary>
        /// NNBF37.
        /// </summary>
        public const string NNBF37 = "NNBF37";

        /// <summary>
        /// NNBF38.
        /// </summary>
        public const string NNBF38 = "NNBF38";

        /// <summary>
        /// NNBF39.
        /// </summary>
        public const string NNBF39 = "NNBF39";

        /// <summary>
        /// NNBF40.
        /// </summary>
        public const string NNBF40 = "NNBF40";

        /// <summary>
        /// NNBF41.
        /// </summary>
        public const string NNBF41 = "NNBF41";

        /// <summary>
        /// NNBF42.
        /// </summary>
        public const string NNBF42 = "NNBF42";

        /// <summary>
        /// NNBF43.
        /// </summary>
        public const string NNBF43 = "NNBF43";

        /// <summary>
        /// NNBF44.
        /// </summary>
        public const string NNBF44 = "NNBF44";

        /// <summary>
        /// NNBF45.
        /// </summary>
        public const string NNBF45 = "NNBF45";

        /// <summary>
        /// NNBF46.
        /// </summary>
        public const string NNBF46 = "NNBF46";

        /// <summary>
        /// NNBF47.
        /// </summary>
        public const string NNBF47 = "NNBF47";

        /// <summary>
        /// NNBF48.
        /// </summary>
        public const string NNBF48 = "NNBF48";

        /// <summary>
        /// NNBF49.
        /// </summary>
        public const string NNBF49 = "NNBF49";

        /// <summary>
        /// NNBF50.
        /// </summary>
        public const string NNBF50 = "NNBF50";

        /// <summary>
        /// NNBF51.
        /// </summary>
        public const string NNBF51 = "NNBF51";

        /// <summary>
        /// NNBF52.
        /// </summary>
        public const string NNBF52 = "NNBF52";

        /// <summary>
        /// NNBF53.
        /// </summary>
        public const string NNBF53 = "NNBF53";

        /// <summary>
        /// NNBF54.
        /// </summary>
        public const string NNBF54 = "NNBF54";

        /// <summary>
        /// NNLSVR.
        /// </summary>
        public const string NNLSVR = "NNLSVR";

        /// <summary>
        /// NNBCI3.
        /// </summary>
        public const string NNBCI3 = "NNBCI3";

        /// <summary>
        /// NNVRSC.
        /// </summary>
        public const string NNVRSC = "NNVRSC";

        /// <summary>
        /// NNURCD.
        /// </summary>
        public const string NNURCD = "NNURCD";

        /// <summary>
        /// NNURDT.
        /// </summary>
        public const string NNURDT = "NNURDT";

        /// <summary>
        /// NNURAT.
        /// </summary>
        public const string NNURAT = "NNURAT";

        /// <summary>
        /// NNURAB.
        /// </summary>
        public const string NNURAB = "NNURAB";

        /// <summary>
        /// NNURRF.
        /// </summary>
        public const string NNURRF = "NNURRF";

        /// <summary>
        /// NNUSER.
        /// </summary>
        public const string NNUSER = "NNUSER";

        /// <summary>
        /// NNPID.
        /// </summary>
        public const string NNPID = "NNPID";

        /// <summary>
        /// NNUPMJ.
        /// </summary>
        public const string NNUPMJ = "NNUPMJ";

        /// <summary>
        /// NNUPMT.
        /// </summary>
        public const string NNUPMT = "NNUPMT";

        /// <summary>
        /// NNJOBN.
        /// </summary>
        public const string NNJOBN = "NNJOBN";

        /// <summary>
        /// NNENTJ.
        /// </summary>
        public const string NNENTJ = "NNENTJ";

        /// <summary>
        /// NNTORG.
        /// </summary>
        public const string NNTORG = "NNTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F15020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NNDOCO", "NNDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NNBCI", "NNBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NNBLFC", "NNBLFC", JdeDataType.String, 2, true, true),
        new JdeField("NNGENT", "NNGENT", JdeDataType.String, 2, true, true),
        new JdeField("NNSUSP", "NNSUSP", JdeDataType.String, 2),
        new JdeField("NNSUDT", "NNSUDT", JdeDataType.Numeric),
        new JdeField("NNBF14", "NNBF14", JdeDataType.String, 2),
        new JdeField("NNBF15", "NNBF15", JdeDataType.String, 2),
        new JdeField("NNBF16", "NNBF16", JdeDataType.String, 2),
        new JdeField("NNBF17", "NNBF17", JdeDataType.String, 2),
        new JdeField("NNBF18", "NNBF18", JdeDataType.String, 2),
        new JdeField("NNBF19", "NNBF19", JdeDataType.String, 2),
        new JdeField("NNBF20", "NNBF20", JdeDataType.String, 2),
        new JdeField("NNBF21", "NNBF21", JdeDataType.String, 2),
        new JdeField("NNBF22", "NNBF22", JdeDataType.String, 2),
        new JdeField("NNBF23", "NNBF23", JdeDataType.String, 2),
        new JdeField("NNBF24", "NNBF24", JdeDataType.String, 2),
        new JdeField("NNBF25", "NNBF25", JdeDataType.String, 2),
        new JdeField("NNBF26", "NNBF26", JdeDataType.String, 2),
        new JdeField("NNBF27", "NNBF27", JdeDataType.String, 2),
        new JdeField("NNBF28", "NNBF28", JdeDataType.String, 2),
        new JdeField("NNBF29", "NNBF29", JdeDataType.String, 2),
        new JdeField("NNBF30", "NNBF30", JdeDataType.String, 2),
        new JdeField("NNBF31", "NNBF31", JdeDataType.String, 2),
        new JdeField("NNBF32", "NNBF32", JdeDataType.String, 2),
        new JdeField("NNBF33", "NNBF33", JdeDataType.String, 2),
        new JdeField("NNBF34", "NNBF34", JdeDataType.String, 2),
        new JdeField("NNBF35", "NNBF35", JdeDataType.String, 2),
        new JdeField("NNBF36", "NNBF36", JdeDataType.String, 2),
        new JdeField("NNBF37", "NNBF37", JdeDataType.String, 2),
        new JdeField("NNBF38", "NNBF38", JdeDataType.String, 2),
        new JdeField("NNBF39", "NNBF39", JdeDataType.String, 2),
        new JdeField("NNBF40", "NNBF40", JdeDataType.String, 2),
        new JdeField("NNBF41", "NNBF41", JdeDataType.String, 2),
        new JdeField("NNBF42", "NNBF42", JdeDataType.String, 2),
        new JdeField("NNBF43", "NNBF43", JdeDataType.String, 2),
        new JdeField("NNBF44", "NNBF44", JdeDataType.String, 2),
        new JdeField("NNBF45", "NNBF45", JdeDataType.String, 2),
        new JdeField("NNBF46", "NNBF46", JdeDataType.String, 2),
        new JdeField("NNBF47", "NNBF47", JdeDataType.String, 2),
        new JdeField("NNBF48", "NNBF48", JdeDataType.String, 2),
        new JdeField("NNBF49", "NNBF49", JdeDataType.String, 2),
        new JdeField("NNBF50", "NNBF50", JdeDataType.String, 2),
        new JdeField("NNBF51", "NNBF51", JdeDataType.String, 2),
        new JdeField("NNBF52", "NNBF52", JdeDataType.String, 2),
        new JdeField("NNBF53", "NNBF53", JdeDataType.String, 2),
        new JdeField("NNBF54", "NNBF54", JdeDataType.String, 2),
        new JdeField("NNLSVR", "NNLSVR", JdeDataType.Numeric),
        new JdeField("NNBCI3", "NNBCI3", JdeDataType.Numeric),
        new JdeField("NNVRSC", "NNVRSC", JdeDataType.String, 2),
        new JdeField("NNURCD", "NNURCD", JdeDataType.String, 4),
        new JdeField("NNURDT", "NNURDT", JdeDataType.Numeric),
        new JdeField("NNURAT", "NNURAT", JdeDataType.Numeric),
        new JdeField("NNURAB", "NNURAB", JdeDataType.Numeric),
        new JdeField("NNURRF", "NNURRF", JdeDataType.String, 30),
        new JdeField("NNUSER", "NNUSER", JdeDataType.String, 20),
        new JdeField("NNPID", "NNPID", JdeDataType.String, 20),
        new JdeField("NNUPMJ", "NNUPMJ", JdeDataType.Numeric),
        new JdeField("NNUPMT", "NNUPMT", JdeDataType.Numeric),
        new JdeField("NNJOBN", "NNJOBN", JdeDataType.String, 20),
        new JdeField("NNENTJ", "NNENTJ", JdeDataType.Numeric),
        new JdeField("NNTORG", "NNTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15020_0", "Primary Key on NNDOCO, NNBCI, NNGENT, NNBLFC", new[] { "NNDOCO", "NNBCI", "NNGENT", "NNBLFC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15020_2", "Index on NNBCI3", new[] { "NNBCI3" }),
        new JdeIndex("F15020_3", "Index on NNBCI", new[] { "NNBCI" }),
        new JdeIndex("F15020_4", "Index on NNBCI, NNGENT", new[] { "NNBCI", "NNGENT" })
    };
}
