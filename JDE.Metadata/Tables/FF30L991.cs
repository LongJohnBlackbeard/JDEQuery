using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L991 - .
/// </summary>
public class FF30L991 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MDDFCFGID.
        /// </summary>
        public const string MDDFCFGID = "MDDFCFGID";

        /// <summary>
        /// MDDFMOVID.
        /// </summary>
        public const string MDDFMOVID = "MDDFMOVID";

        /// <summary>
        /// MDDFMOVUBE.
        /// </summary>
        public const string MDDFMOVUBE = "MDDFMOVUBE";

        /// <summary>
        /// MDDFMOVVER.
        /// </summary>
        public const string MDDFMOVVER = "MDDFMOVVER";

        /// <summary>
        /// MDDFMOVEXE.
        /// </summary>
        public const string MDDFMOVEXE = "MDDFMOVEXE";

        /// <summary>
        /// MDDFMOVHC.
        /// </summary>
        public const string MDDFMOVHC = "MDDFMOVHC";

        /// <summary>
        /// MDDFMOVST.
        /// </summary>
        public const string MDDFMOVST = "MDDFMOVST";

        /// <summary>
        /// MDDFMOVDAT.
        /// </summary>
        public const string MDDFMOVDAT = "MDDFMOVDAT";

        /// <summary>
        /// MDUSER.
        /// </summary>
        public const string MDUSER = "MDUSER";

        /// <summary>
        /// MDPID.
        /// </summary>
        public const string MDPID = "MDPID";

        /// <summary>
        /// MDMKEY.
        /// </summary>
        public const string MDMKEY = "MDMKEY";

        /// <summary>
        /// MDUUPMJ.
        /// </summary>
        public const string MDUUPMJ = "MDUUPMJ";

        /// <summary>
        /// MDURCD.
        /// </summary>
        public const string MDURCD = "MDURCD";

        /// <summary>
        /// MDURDT.
        /// </summary>
        public const string MDURDT = "MDURDT";

        /// <summary>
        /// MDURAT.
        /// </summary>
        public const string MDURAT = "MDURAT";

        /// <summary>
        /// MDURAB.
        /// </summary>
        public const string MDURAB = "MDURAB";

        /// <summary>
        /// MDURRF.
        /// </summary>
        public const string MDURRF = "MDURRF";

        /// <summary>
        /// MDFSCID.
        /// </summary>
        public const string MDFSCID = "MDFSCID";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L991";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MDDFCFGID", "MDDFCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("MDDFMOVID", "MDDFMOVID", JdeDataType.Numeric, null, true, true),
        new JdeField("MDDFMOVUBE", "MDDFMOVUBE", JdeDataType.String, 20),
        new JdeField("MDDFMOVVER", "MDDFMOVVER", JdeDataType.String, 20),
        new JdeField("MDDFMOVEXE", "MDDFMOVEXE", JdeDataType.String, 2),
        new JdeField("MDDFMOVHC", "MDDFMOVHC", JdeDataType.String, 2),
        new JdeField("MDDFMOVST", "MDDFMOVST", JdeDataType.String, 4),
        new JdeField("MDDFMOVDAT", "MDDFMOVDAT", JdeDataType.Date),
        new JdeField("MDUSER", "MDUSER", JdeDataType.String, 20),
        new JdeField("MDPID", "MDPID", JdeDataType.String, 20),
        new JdeField("MDMKEY", "MDMKEY", JdeDataType.String, 30),
        new JdeField("MDUUPMJ", "MDUUPMJ", JdeDataType.Date),
        new JdeField("MDURCD", "MDURCD", JdeDataType.String, 4),
        new JdeField("MDURDT", "MDURDT", JdeDataType.Numeric),
        new JdeField("MDURAT", "MDURAT", JdeDataType.Numeric),
        new JdeField("MDURAB", "MDURAB", JdeDataType.Numeric),
        new JdeField("MDURRF", "MDURRF", JdeDataType.String, 30),
        new JdeField("MDFSCID", "MDFSCID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L991_0", "Primary Key on MDDFCFGID, MDDFMOVID", new[] { "MDDFCFGID", "MDDFMOVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L991_2", "Index on MDFSCID", new[] { "MDFSCID" })
    };
}
