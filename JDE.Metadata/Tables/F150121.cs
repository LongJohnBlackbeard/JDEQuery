using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F150121 - .
/// </summary>
public class F150121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NXTEXR.
        /// </summary>
        public const string NXTEXR = "NXTEXR";

        /// <summary>
        /// NXAM01.
        /// </summary>
        public const string NXAM01 = "NXAM01";

        /// <summary>
        /// NXURAB.
        /// </summary>
        public const string NXURAB = "NXURAB";

        /// <summary>
        /// NXURAT.
        /// </summary>
        public const string NXURAT = "NXURAT";

        /// <summary>
        /// NXURCD.
        /// </summary>
        public const string NXURCD = "NXURCD";

        /// <summary>
        /// NXURDT.
        /// </summary>
        public const string NXURDT = "NXURDT";

        /// <summary>
        /// NXURRF.
        /// </summary>
        public const string NXURRF = "NXURRF";

        /// <summary>
        /// NXUPMJ.
        /// </summary>
        public const string NXUPMJ = "NXUPMJ";

        /// <summary>
        /// NXUPMT.
        /// </summary>
        public const string NXUPMT = "NXUPMT";

        /// <summary>
        /// NXUSER.
        /// </summary>
        public const string NXUSER = "NXUSER";

        /// <summary>
        /// NXTORG.
        /// </summary>
        public const string NXTORG = "NXTORG";

        /// <summary>
        /// NXPID.
        /// </summary>
        public const string NXPID = "NXPID";

        /// <summary>
        /// NXENTJ.
        /// </summary>
        public const string NXENTJ = "NXENTJ";

        /// <summary>
        /// NXJOBN.
        /// </summary>
        public const string NXJOBN = "NXJOBN";

        /// <summary>
        /// NXTEAV.
        /// </summary>
        public const string NXTEAV = "NXTEAV";

        /// <summary>
        /// NXXB01.
        /// </summary>
        public const string NXXB01 = "NXXB01";

        /// <summary>
        /// NXXB02.
        /// </summary>
        public const string NXXB02 = "NXXB02";

        /// <summary>
        /// NXXB03.
        /// </summary>
        public const string NXXB03 = "NXXB03";

        /// <summary>
        /// NXXB04.
        /// </summary>
        public const string NXXB04 = "NXXB04";

        /// <summary>
        /// NXXB05.
        /// </summary>
        public const string NXXB05 = "NXXB05";

        /// <summary>
        /// NXXB06.
        /// </summary>
        public const string NXXB06 = "NXXB06";

        /// <summary>
        /// NXXB07.
        /// </summary>
        public const string NXXB07 = "NXXB07";

        /// <summary>
        /// NXXB08.
        /// </summary>
        public const string NXXB08 = "NXXB08";

        /// <summary>
        /// NXXB09.
        /// </summary>
        public const string NXXB09 = "NXXB09";

        /// <summary>
        /// NXXB10.
        /// </summary>
        public const string NXXB10 = "NXXB10";
    }

    /// <inheritdoc />
    public override string TableName => "F150121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NXTEXR", "NXTEXR", JdeDataType.String, 20, true, true),
        new JdeField("NXAM01", "NXAM01", JdeDataType.String, 6, true, true),
        new JdeField("NXURAB", "NXURAB", JdeDataType.Numeric),
        new JdeField("NXURAT", "NXURAT", JdeDataType.Numeric),
        new JdeField("NXURCD", "NXURCD", JdeDataType.String, 4),
        new JdeField("NXURDT", "NXURDT", JdeDataType.Numeric),
        new JdeField("NXURRF", "NXURRF", JdeDataType.String, 30),
        new JdeField("NXUPMJ", "NXUPMJ", JdeDataType.Numeric),
        new JdeField("NXUPMT", "NXUPMT", JdeDataType.Numeric),
        new JdeField("NXUSER", "NXUSER", JdeDataType.String, 20),
        new JdeField("NXTORG", "NXTORG", JdeDataType.String, 20),
        new JdeField("NXPID", "NXPID", JdeDataType.String, 20),
        new JdeField("NXENTJ", "NXENTJ", JdeDataType.Numeric),
        new JdeField("NXJOBN", "NXJOBN", JdeDataType.String, 20),
        new JdeField("NXTEAV", "NXTEAV", JdeDataType.Numeric),
        new JdeField("NXXB01", "NXXB01", JdeDataType.String, 8),
        new JdeField("NXXB02", "NXXB02", JdeDataType.String, 8),
        new JdeField("NXXB03", "NXXB03", JdeDataType.String, 8),
        new JdeField("NXXB04", "NXXB04", JdeDataType.String, 8),
        new JdeField("NXXB05", "NXXB05", JdeDataType.String, 8),
        new JdeField("NXXB06", "NXXB06", JdeDataType.String, 8),
        new JdeField("NXXB07", "NXXB07", JdeDataType.String, 8),
        new JdeField("NXXB08", "NXXB08", JdeDataType.String, 8),
        new JdeField("NXXB09", "NXXB09", JdeDataType.String, 8),
        new JdeField("NXXB10", "NXXB10", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F150121_0", "Primary Key on NXTEXR, NXAM01", new[] { "NXTEXR", "NXAM01" }, isUnique: true, isPrimaryKey: true)
    };
}
