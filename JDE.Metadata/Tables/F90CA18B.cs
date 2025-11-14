using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA18B - .
/// </summary>
public class F90CA18B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGUKID.
        /// </summary>
        public const string IGUKID = "IGUKID";

        /// <summary>
        /// IGCIG.
        /// </summary>
        public const string IGCIG = "IGCIG";

        /// <summary>
        /// IGCOMDATE.
        /// </summary>
        public const string IGCOMDATE = "IGCOMDATE";

        /// <summary>
        /// IGEDATE.
        /// </summary>
        public const string IGEDATE = "IGEDATE";

        /// <summary>
        /// IGSTSUDT.
        /// </summary>
        public const string IGSTSUDT = "IGSTSUDT";

        /// <summary>
        /// IGACTIND.
        /// </summary>
        public const string IGACTIND = "IGACTIND";

        /// <summary>
        /// IGUSER.
        /// </summary>
        public const string IGUSER = "IGUSER";

        /// <summary>
        /// IGPID.
        /// </summary>
        public const string IGPID = "IGPID";

        /// <summary>
        /// IGVID.
        /// </summary>
        public const string IGVID = "IGVID";

        /// <summary>
        /// IGMKEY.
        /// </summary>
        public const string IGMKEY = "IGMKEY";

        /// <summary>
        /// IGUDTTM.
        /// </summary>
        public const string IGUDTTM = "IGUDTTM";

        /// <summary>
        /// IGENTDBY.
        /// </summary>
        public const string IGENTDBY = "IGENTDBY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA18B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGUKID", "IGUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IGCIG", "IGCIG", JdeDataType.Numeric, null, true, true),
        new JdeField("IGCOMDATE", "IGCOMDATE", JdeDataType.Date),
        new JdeField("IGEDATE", "IGEDATE", JdeDataType.Date),
        new JdeField("IGSTSUDT", "IGSTSUDT", JdeDataType.Date),
        new JdeField("IGACTIND", "IGACTIND", JdeDataType.String, 2),
        new JdeField("IGUSER", "IGUSER", JdeDataType.String, 20),
        new JdeField("IGPID", "IGPID", JdeDataType.String, 20),
        new JdeField("IGVID", "IGVID", JdeDataType.String, 20),
        new JdeField("IGMKEY", "IGMKEY", JdeDataType.String, 30),
        new JdeField("IGUDTTM", "IGUDTTM", JdeDataType.Date),
        new JdeField("IGENTDBY", "IGENTDBY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA18B_0", "Primary Key on IGCIG, IGUKID", new[] { "IGCIG", "IGUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA18B_2", "Index on IGCOMDATE", new[] { "IGCOMDATE" })
    };
}
