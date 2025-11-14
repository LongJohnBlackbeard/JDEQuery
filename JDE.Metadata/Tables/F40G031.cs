using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G031 - .
/// </summary>
public class F40G031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FHFRZID.
        /// </summary>
        public const string FHFRZID = "FHFRZID";

        /// <summary>
        /// FHTYPEHB.
        /// </summary>
        public const string FHTYPEHB = "FHTYPEHB";

        /// <summary>
        /// FHWVID.
        /// </summary>
        public const string FHWVID = "FHWVID";

        /// <summary>
        /// FHUPLNMAT.
        /// </summary>
        public const string FHUPLNMAT = "FHUPLNMAT";

        /// <summary>
        /// FHFRZNAME.
        /// </summary>
        public const string FHFRZNAME = "FHFRZNAME";

        /// <summary>
        /// FHGEOCST.
        /// </summary>
        public const string FHGEOCST = "FHGEOCST";

        /// <summary>
        /// FHFRZDT.
        /// </summary>
        public const string FHFRZDT = "FHFRZDT";

        /// <summary>
        /// FHUCLCMAT.
        /// </summary>
        public const string FHUCLCMAT = "FHUCLCMAT";

        /// <summary>
        /// FHHAREST.
        /// </summary>
        public const string FHHAREST = "FHHAREST";

        /// <summary>
        /// FHUM.
        /// </summary>
        public const string FHUM = "FHUM";

        /// <summary>
        /// FHURCD.
        /// </summary>
        public const string FHURCD = "FHURCD";

        /// <summary>
        /// FHURDT.
        /// </summary>
        public const string FHURDT = "FHURDT";

        /// <summary>
        /// FHURRF.
        /// </summary>
        public const string FHURRF = "FHURRF";

        /// <summary>
        /// FHURAT.
        /// </summary>
        public const string FHURAT = "FHURAT";

        /// <summary>
        /// FHURAB.
        /// </summary>
        public const string FHURAB = "FHURAB";

        /// <summary>
        /// FHUSER.
        /// </summary>
        public const string FHUSER = "FHUSER";

        /// <summary>
        /// FHTORG.
        /// </summary>
        public const string FHTORG = "FHTORG";

        /// <summary>
        /// FHJOBN.
        /// </summary>
        public const string FHJOBN = "FHJOBN";

        /// <summary>
        /// FHPID.
        /// </summary>
        public const string FHPID = "FHPID";

        /// <summary>
        /// FHUUPMJ.
        /// </summary>
        public const string FHUUPMJ = "FHUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FHFRZID", "FHFRZID", JdeDataType.Numeric, null, true, true),
        new JdeField("FHTYPEHB", "FHTYPEHB", JdeDataType.String, 2, true, true),
        new JdeField("FHWVID", "FHWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("FHUPLNMAT", "FHUPLNMAT", JdeDataType.Date, null, true, true),
        new JdeField("FHFRZNAME", "FHFRZNAME", JdeDataType.String, 80),
        new JdeField("FHGEOCST", "FHGEOCST", JdeDataType.String, 6),
        new JdeField("FHFRZDT", "FHFRZDT", JdeDataType.Date),
        new JdeField("FHUCLCMAT", "FHUCLCMAT", JdeDataType.Date),
        new JdeField("FHHAREST", "FHHAREST", JdeDataType.Numeric),
        new JdeField("FHUM", "FHUM", JdeDataType.String, 4),
        new JdeField("FHURCD", "FHURCD", JdeDataType.String, 4),
        new JdeField("FHURDT", "FHURDT", JdeDataType.Numeric),
        new JdeField("FHURRF", "FHURRF", JdeDataType.String, 30),
        new JdeField("FHURAT", "FHURAT", JdeDataType.Numeric),
        new JdeField("FHURAB", "FHURAB", JdeDataType.Numeric),
        new JdeField("FHUSER", "FHUSER", JdeDataType.String, 20),
        new JdeField("FHTORG", "FHTORG", JdeDataType.String, 20),
        new JdeField("FHJOBN", "FHJOBN", JdeDataType.String, 20),
        new JdeField("FHPID", "FHPID", JdeDataType.String, 20),
        new JdeField("FHUUPMJ", "FHUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G031_0", "Primary Key on FHFRZID, FHTYPEHB, FHWVID, FHUPLNMAT", new[] { "FHFRZID", "FHTYPEHB", "FHWVID", "FHUPLNMAT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G031_2", "Index on FHFRZNAME, FHWVID", new[] { "FHFRZNAME", "FHWVID" })
    };
}
