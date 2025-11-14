using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K42 - .
/// </summary>
public class FF31K42 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCFSCID.
        /// </summary>
        public const string LCFSCID = "LCFSCID";

        /// <summary>
        /// LCDFMCU.
        /// </summary>
        public const string LCDFMCU = "LCDFMCU";

        /// <summary>
        /// LCDFLOCN.
        /// </summary>
        public const string LCDFLOCN = "LCDFLOCN";

        /// <summary>
        /// LCDFMCELL.
        /// </summary>
        public const string LCDFMCELL = "LCDFMCELL";

        /// <summary>
        /// LCURAB.
        /// </summary>
        public const string LCURAB = "LCURAB";

        /// <summary>
        /// LCURCD.
        /// </summary>
        public const string LCURCD = "LCURCD";

        /// <summary>
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";

        /// <summary>
        /// LCURDT.
        /// </summary>
        public const string LCURDT = "LCURDT";

        /// <summary>
        /// LCURAT.
        /// </summary>
        public const string LCURAT = "LCURAT";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCTORG.
        /// </summary>
        public const string LCTORG = "LCTORG";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCUUPMJ.
        /// </summary>
        public const string LCUUPMJ = "LCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K42";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCFSCID", "LCFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("LCDFMCU", "LCDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("LCDFLOCN", "LCDFLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LCDFMCELL", "LCDFMCELL", JdeDataType.String, 2),
        new JdeField("LCURAB", "LCURAB", JdeDataType.Numeric),
        new JdeField("LCURCD", "LCURCD", JdeDataType.String, 4),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30),
        new JdeField("LCURDT", "LCURDT", JdeDataType.Numeric),
        new JdeField("LCURAT", "LCURAT", JdeDataType.Numeric),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCTORG", "LCTORG", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCUUPMJ", "LCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K42_0", "Primary Key on LCFSCID, LCDFMCU, LCDFLOCN", new[] { "LCFSCID", "LCDFMCU", "LCDFLOCN" }, isUnique: true, isPrimaryKey: true)
    };
}
