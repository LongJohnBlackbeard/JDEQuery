using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0015 - .
/// </summary>
public class F0015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CXCRCD.
        /// </summary>
        public const string CXCRCD = "CXCRCD";

        /// <summary>
        /// CXCRDC.
        /// </summary>
        public const string CXCRDC = "CXCRDC";

        /// <summary>
        /// CXAN8.
        /// </summary>
        public const string CXAN8 = "CXAN8";

        /// <summary>
        /// CXRTTYP.
        /// </summary>
        public const string CXRTTYP = "CXRTTYP";

        /// <summary>
        /// CXEFT.
        /// </summary>
        public const string CXEFT = "CXEFT";

        /// <summary>
        /// CXCLMETH.
        /// </summary>
        public const string CXCLMETH = "CXCLMETH";

        /// <summary>
        /// CXCRCM.
        /// </summary>
        public const string CXCRCM = "CXCRCM";

        /// <summary>
        /// CXTRCR.
        /// </summary>
        public const string CXTRCR = "CXTRCR";

        /// <summary>
        /// CXCRR.
        /// </summary>
        public const string CXCRR = "CXCRR";

        /// <summary>
        /// CXCRRD.
        /// </summary>
        public const string CXCRRD = "CXCRRD";

        /// <summary>
        /// CXCSR.
        /// </summary>
        public const string CXCSR = "CXCSR";

        /// <summary>
        /// CXUSER.
        /// </summary>
        public const string CXUSER = "CXUSER";

        /// <summary>
        /// CXPID.
        /// </summary>
        public const string CXPID = "CXPID";

        /// <summary>
        /// CXJOBN.
        /// </summary>
        public const string CXJOBN = "CXJOBN";

        /// <summary>
        /// CXUPMJ.
        /// </summary>
        public const string CXUPMJ = "CXUPMJ";

        /// <summary>
        /// CXUPMT.
        /// </summary>
        public const string CXUPMT = "CXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CXCRCD", "CXCRCD", JdeDataType.String, 6, true, true),
        new JdeField("CXCRDC", "CXCRDC", JdeDataType.String, 6, true, true),
        new JdeField("CXAN8", "CXAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CXRTTYP", "CXRTTYP", JdeDataType.String, 4, true, true),
        new JdeField("CXEFT", "CXEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("CXCLMETH", "CXCLMETH", JdeDataType.String, 2),
        new JdeField("CXCRCM", "CXCRCM", JdeDataType.String, 2),
        new JdeField("CXTRCR", "CXTRCR", JdeDataType.String, 6),
        new JdeField("CXCRR", "CXCRR", JdeDataType.Numeric),
        new JdeField("CXCRRD", "CXCRRD", JdeDataType.Numeric),
        new JdeField("CXCSR", "CXCSR", JdeDataType.String, 2),
        new JdeField("CXUSER", "CXUSER", JdeDataType.String, 20),
        new JdeField("CXPID", "CXPID", JdeDataType.String, 20),
        new JdeField("CXJOBN", "CXJOBN", JdeDataType.String, 20),
        new JdeField("CXUPMJ", "CXUPMJ", JdeDataType.Numeric),
        new JdeField("CXUPMT", "CXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0015_0", "Primary Key on CXCRCD, CXCRDC, CXAN8, CXRTTYP, CXEFT", new[] { "CXCRCD", "CXCRDC", "CXAN8", "CXRTTYP", "CXEFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0015_2", "Index on CXAN8, CXCRDC, CXCRCD, SYS_NC00017$", new[] { "CXAN8", "CXCRDC", "CXCRCD", "SYS_NC00017$" }),
        new JdeIndex("F0015_3", "Index on CXCRCD, CXCRDC, CXAN8, CXRTTYP, SYS_NC00017$", new[] { "CXCRCD", "CXCRDC", "CXAN8", "CXRTTYP", "SYS_NC00017$" }),
        new JdeIndex("F0015_4", "Index on CXCRCD, CXCRDC, CXAN8, CXRTTYP", new[] { "CXCRCD", "CXCRDC", "CXAN8", "CXRTTYP" })
    };
}
