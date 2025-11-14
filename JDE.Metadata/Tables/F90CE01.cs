using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CE01 - .
/// </summary>
public class F90CE01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STSLTNID.
        /// </summary>
        public const string STSLTNID = "STSLTNID";

        /// <summary>
        /// STLIBID.
        /// </summary>
        public const string STLIBID = "STLIBID";

        /// <summary>
        /// STSLSMY.
        /// </summary>
        public const string STSLSMY = "STSLSMY";

        /// <summary>
        /// STSLTNST.
        /// </summary>
        public const string STSLTNST = "STSLTNST";

        /// <summary>
        /// STSLTNTY.
        /// </summary>
        public const string STSLTNTY = "STSLTNTY";

        /// <summary>
        /// STSLTNVI.
        /// </summary>
        public const string STSLTNVI = "STSLTNVI";

        /// <summary>
        /// STKEYWD.
        /// </summary>
        public const string STKEYWD = "STKEYWD";

        /// <summary>
        /// STSYMPT.
        /// </summary>
        public const string STSYMPT = "STSYMPT";

        /// <summary>
        /// STDETAIL.
        /// </summary>
        public const string STDETAIL = "STDETAIL";

        /// <summary>
        /// STSLVCNT.
        /// </summary>
        public const string STSLVCNT = "STSLVCNT";

        /// <summary>
        /// STUSGCNT.
        /// </summary>
        public const string STUSGCNT = "STUSGCNT";

        /// <summary>
        /// STLSUSG.
        /// </summary>
        public const string STLSUSG = "STLSUSG";

        /// <summary>
        /// STSETID.
        /// </summary>
        public const string STSETID = "STSETID";

        /// <summary>
        /// STENTDBY.
        /// </summary>
        public const string STENTDBY = "STENTDBY";

        /// <summary>
        /// STEDATE.
        /// </summary>
        public const string STEDATE = "STEDATE";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STUDTTM.
        /// </summary>
        public const string STUDTTM = "STUDTTM";

        /// <summary>
        /// STMKEY.
        /// </summary>
        public const string STMKEY = "STMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CE01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STSLTNID", "STSLTNID", JdeDataType.Numeric, null, true, true),
        new JdeField("STLIBID", "STLIBID", JdeDataType.Numeric),
        new JdeField("STSLSMY", "STSLSMY", JdeDataType.String, 160),
        new JdeField("STSLTNST", "STSLTNST", JdeDataType.String, 4),
        new JdeField("STSLTNTY", "STSLTNTY", JdeDataType.String, 8),
        new JdeField("STSLTNVI", "STSLTNVI", JdeDataType.String, 4),
        new JdeField("STKEYWD", "STKEYWD", JdeDataType.String, 200),
        new JdeField("STSYMPT", "STSYMPT", JdeDataType.String, 508),
        new JdeField("STDETAIL", "STDETAIL", JdeDataType.String, 3998),
        new JdeField("STSLVCNT", "STSLVCNT", JdeDataType.Numeric),
        new JdeField("STUSGCNT", "STUSGCNT", JdeDataType.Numeric),
        new JdeField("STLSUSG", "STLSUSG", JdeDataType.Date),
        new JdeField("STSETID", "STSETID", JdeDataType.String, 10),
        new JdeField("STENTDBY", "STENTDBY", JdeDataType.Numeric),
        new JdeField("STEDATE", "STEDATE", JdeDataType.Date),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STUDTTM", "STUDTTM", JdeDataType.Date),
        new JdeField("STMKEY", "STMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CE01_0", "Primary Key on STSLTNID", new[] { "STSLTNID" }, isUnique: true, isPrimaryKey: true)
    };
}
