using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B23 - .
/// </summary>
public class F03B23 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTUKID.
        /// </summary>
        public const string RTUKID = "RTUKID";

        /// <summary>
        /// RTRC5.
        /// </summary>
        public const string RTRC5 = "RTRC5";

        /// <summary>
        /// RTDOC.
        /// </summary>
        public const string RTDOC = "RTDOC";

        /// <summary>
        /// RTDCT.
        /// </summary>
        public const string RTDCT = "RTDCT";

        /// <summary>
        /// RTKCO.
        /// </summary>
        public const string RTKCO = "RTKCO";

        /// <summary>
        /// RTSFX.
        /// </summary>
        public const string RTSFX = "RTSFX";

        /// <summary>
        /// RTAN8.
        /// </summary>
        public const string RTAN8 = "RTAN8";

        /// <summary>
        /// RTDFEE.
        /// </summary>
        public const string RTDFEE = "RTDFEE";

        /// <summary>
        /// RTASLC.
        /// </summary>
        public const string RTASLC = "RTASLC";

        /// <summary>
        /// RTFFEE.
        /// </summary>
        public const string RTFFEE = "RTFFEE";

        /// <summary>
        /// RTFSLC.
        /// </summary>
        public const string RTFSLC = "RTFSLC";

        /// <summary>
        /// RTBCRC.
        /// </summary>
        public const string RTBCRC = "RTBCRC";

        /// <summary>
        /// RTCRCD.
        /// </summary>
        public const string RTCRCD = "RTCRCD";

        /// <summary>
        /// RTCRRM.
        /// </summary>
        public const string RTCRRM = "RTCRRM";

        /// <summary>
        /// RTCRR.
        /// </summary>
        public const string RTCRR = "RTCRR";

        /// <summary>
        /// RTPLY.
        /// </summary>
        public const string RTPLY = "RTPLY";

        /// <summary>
        /// RTLNID.
        /// </summary>
        public const string RTLNID = "RTLNID";

        /// <summary>
        /// RTALPH.
        /// </summary>
        public const string RTALPH = "RTALPH";

        /// <summary>
        /// RTCO.
        /// </summary>
        public const string RTCO = "RTCO";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B23";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTUKID", "RTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTRC5", "RTRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("RTDOC", "RTDOC", JdeDataType.Numeric),
        new JdeField("RTDCT", "RTDCT", JdeDataType.String, 4),
        new JdeField("RTKCO", "RTKCO", JdeDataType.String, 10),
        new JdeField("RTSFX", "RTSFX", JdeDataType.String, 6),
        new JdeField("RTAN8", "RTAN8", JdeDataType.Numeric),
        new JdeField("RTDFEE", "RTDFEE", JdeDataType.Numeric),
        new JdeField("RTASLC", "RTASLC", JdeDataType.Numeric),
        new JdeField("RTFFEE", "RTFFEE", JdeDataType.Numeric),
        new JdeField("RTFSLC", "RTFSLC", JdeDataType.Numeric),
        new JdeField("RTBCRC", "RTBCRC", JdeDataType.String, 6),
        new JdeField("RTCRCD", "RTCRCD", JdeDataType.String, 6),
        new JdeField("RTCRRM", "RTCRRM", JdeDataType.String, 2),
        new JdeField("RTCRR", "RTCRR", JdeDataType.Numeric),
        new JdeField("RTPLY", "RTPLY", JdeDataType.Numeric),
        new JdeField("RTLNID", "RTLNID", JdeDataType.Numeric),
        new JdeField("RTALPH", "RTALPH", JdeDataType.String, 80),
        new JdeField("RTCO", "RTCO", JdeDataType.String, 10),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B23_0", "Primary Key on RTUKID, RTRC5", new[] { "RTUKID", "RTRC5" }, isUnique: true, isPrimaryKey: true)
    };
}
