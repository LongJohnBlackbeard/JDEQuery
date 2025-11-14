using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47192 - .
/// </summary>
public class F47192 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AEEDTY.
        /// </summary>
        public const string AEEDTY = "AEEDTY";

        /// <summary>
        /// AEEDSQ.
        /// </summary>
        public const string AEEDSQ = "AEEDSQ";

        /// <summary>
        /// AEEKCO.
        /// </summary>
        public const string AEEKCO = "AEEKCO";

        /// <summary>
        /// AEEDOC.
        /// </summary>
        public const string AEEDOC = "AEEDOC";

        /// <summary>
        /// AEEDCT.
        /// </summary>
        public const string AEEDCT = "AEEDCT";

        /// <summary>
        /// AEEDLN.
        /// </summary>
        public const string AEEDLN = "AEEDLN";

        /// <summary>
        /// AEEDST.
        /// </summary>
        public const string AEEDST = "AEEDST";

        /// <summary>
        /// AEEDFT.
        /// </summary>
        public const string AEEDFT = "AEEDFT";

        /// <summary>
        /// AEEDDT.
        /// </summary>
        public const string AEEDDT = "AEEDDT";

        /// <summary>
        /// AEEDER.
        /// </summary>
        public const string AEEDER = "AEEDER";

        /// <summary>
        /// AEEDDL.
        /// </summary>
        public const string AEEDDL = "AEEDDL";

        /// <summary>
        /// AEEDSP.
        /// </summary>
        public const string AEEDSP = "AEEDSP";

        /// <summary>
        /// AEEDBT.
        /// </summary>
        public const string AEEDBT = "AEEDBT";

        /// <summary>
        /// AESEGERRID.
        /// </summary>
        public const string AESEGERRID = "AESEGERRID";

        /// <summary>
        /// AESEGID.
        /// </summary>
        public const string AESEGID = "AESEGID";

        /// <summary>
        /// AESEGPOS.
        /// </summary>
        public const string AESEGPOS = "AESEGPOS";

        /// <summary>
        /// AEELEPOS.
        /// </summary>
        public const string AEELEPOS = "AEELEPOS";

        /// <summary>
        /// AEELEREFNO.
        /// </summary>
        public const string AEELEREFNO = "AEELEREFNO";

        /// <summary>
        /// AEBADELE.
        /// </summary>
        public const string AEBADELE = "AEBADELE";

        /// <summary>
        /// AENEWELE.
        /// </summary>
        public const string AENEWELE = "AENEWELE";

        /// <summary>
        /// AELOOPID.
        /// </summary>
        public const string AELOOPID = "AELOOPID";

        /// <summary>
        /// AEELEERRCD.
        /// </summary>
        public const string AEELEERRCD = "AEELEERRCD";

        /// <summary>
        /// AEUSER.
        /// </summary>
        public const string AEUSER = "AEUSER";

        /// <summary>
        /// AEPID.
        /// </summary>
        public const string AEPID = "AEPID";

        /// <summary>
        /// AEJOBN.
        /// </summary>
        public const string AEJOBN = "AEJOBN";

        /// <summary>
        /// AEUPMJ.
        /// </summary>
        public const string AEUPMJ = "AEUPMJ";

        /// <summary>
        /// AETDAY.
        /// </summary>
        public const string AETDAY = "AETDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47192";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AEEDTY", "AEEDTY", JdeDataType.String, 2),
        new JdeField("AEEDSQ", "AEEDSQ", JdeDataType.Numeric),
        new JdeField("AEEKCO", "AEEKCO", JdeDataType.String, 10, true, true),
        new JdeField("AEEDOC", "AEEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AEEDCT", "AEEDCT", JdeDataType.String, 4, true, true),
        new JdeField("AEEDLN", "AEEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("AEEDST", "AEEDST", JdeDataType.String, 12),
        new JdeField("AEEDFT", "AEEDFT", JdeDataType.String, 20),
        new JdeField("AEEDDT", "AEEDDT", JdeDataType.Numeric),
        new JdeField("AEEDER", "AEEDER", JdeDataType.String, 2),
        new JdeField("AEEDDL", "AEEDDL", JdeDataType.Numeric),
        new JdeField("AEEDSP", "AEEDSP", JdeDataType.String, 2),
        new JdeField("AEEDBT", "AEEDBT", JdeDataType.String, 30),
        new JdeField("AESEGERRID", "AESEGERRID", JdeDataType.String, 6),
        new JdeField("AESEGID", "AESEGID", JdeDataType.String, 6),
        new JdeField("AESEGPOS", "AESEGPOS", JdeDataType.Numeric),
        new JdeField("AEELEPOS", "AEELEPOS", JdeDataType.Numeric),
        new JdeField("AEELEREFNO", "AEELEREFNO", JdeDataType.Numeric),
        new JdeField("AEBADELE", "AEBADELE", JdeDataType.String, 70),
        new JdeField("AENEWELE", "AENEWELE", JdeDataType.String, 70),
        new JdeField("AELOOPID", "AELOOPID", JdeDataType.String, 8),
        new JdeField("AEELEERRCD", "AEELEERRCD", JdeDataType.String, 6),
        new JdeField("AEUSER", "AEUSER", JdeDataType.String, 20),
        new JdeField("AEPID", "AEPID", JdeDataType.String, 20),
        new JdeField("AEJOBN", "AEJOBN", JdeDataType.String, 20),
        new JdeField("AEUPMJ", "AEUPMJ", JdeDataType.Numeric),
        new JdeField("AETDAY", "AETDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47192_0", "Primary Key on AEEKCO, AEEDOC, AEEDCT, AEEDLN", new[] { "AEEKCO", "AEEDOC", "AEEDCT", "AEEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
