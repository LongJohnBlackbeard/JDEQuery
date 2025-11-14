using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T60 - .
/// </summary>
public class F49T60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IVEDOC.
        /// </summary>
        public const string IVEDOC = "IVEDOC";

        /// <summary>
        /// IVEDCT.
        /// </summary>
        public const string IVEDCT = "IVEDCT";

        /// <summary>
        /// IVEKCO.
        /// </summary>
        public const string IVEKCO = "IVEKCO";

        /// <summary>
        /// IVVXID.
        /// </summary>
        public const string IVVXID = "IVVXID";

        /// <summary>
        /// IVSPINV.
        /// </summary>
        public const string IVSPINV = "IVSPINV";

        /// <summary>
        /// IVTRMNUM.
        /// </summary>
        public const string IVTRMNUM = "IVTRMNUM";

        /// <summary>
        /// IVOTDOMAIN.
        /// </summary>
        public const string IVOTDOMAIN = "IVOTDOMAIN";

        /// <summary>
        /// IVURCD.
        /// </summary>
        public const string IVURCD = "IVURCD";

        /// <summary>
        /// IVURDT.
        /// </summary>
        public const string IVURDT = "IVURDT";

        /// <summary>
        /// IVURRF.
        /// </summary>
        public const string IVURRF = "IVURRF";

        /// <summary>
        /// IVURAT.
        /// </summary>
        public const string IVURAT = "IVURAT";

        /// <summary>
        /// IVURAB.
        /// </summary>
        public const string IVURAB = "IVURAB";

        /// <summary>
        /// IVTORG.
        /// </summary>
        public const string IVTORG = "IVTORG";

        /// <summary>
        /// IVUSER.
        /// </summary>
        public const string IVUSER = "IVUSER";

        /// <summary>
        /// IVPID.
        /// </summary>
        public const string IVPID = "IVPID";

        /// <summary>
        /// IVJOBN.
        /// </summary>
        public const string IVJOBN = "IVJOBN";

        /// <summary>
        /// IVUPMJ.
        /// </summary>
        public const string IVUPMJ = "IVUPMJ";

        /// <summary>
        /// IVTDAY.
        /// </summary>
        public const string IVTDAY = "IVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49T60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IVEDOC", "IVEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IVEDCT", "IVEDCT", JdeDataType.String, 4, true, true),
        new JdeField("IVEKCO", "IVEKCO", JdeDataType.String, 10, true, true),
        new JdeField("IVVXID", "IVVXID", JdeDataType.String, 220),
        new JdeField("IVSPINV", "IVSPINV", JdeDataType.String, 400),
        new JdeField("IVTRMNUM", "IVTRMNUM", JdeDataType.String, 22),
        new JdeField("IVOTDOMAIN", "IVOTDOMAIN", JdeDataType.String, 100),
        new JdeField("IVURCD", "IVURCD", JdeDataType.String, 4),
        new JdeField("IVURDT", "IVURDT", JdeDataType.Numeric),
        new JdeField("IVURRF", "IVURRF", JdeDataType.String, 30),
        new JdeField("IVURAT", "IVURAT", JdeDataType.Numeric),
        new JdeField("IVURAB", "IVURAB", JdeDataType.Numeric),
        new JdeField("IVTORG", "IVTORG", JdeDataType.String, 20),
        new JdeField("IVUSER", "IVUSER", JdeDataType.String, 20),
        new JdeField("IVPID", "IVPID", JdeDataType.String, 20),
        new JdeField("IVJOBN", "IVJOBN", JdeDataType.String, 20),
        new JdeField("IVUPMJ", "IVUPMJ", JdeDataType.Numeric),
        new JdeField("IVTDAY", "IVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T60_0", "Primary Key on IVEDOC, IVEDCT, IVEKCO", new[] { "IVEDOC", "IVEDCT", "IVEKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
