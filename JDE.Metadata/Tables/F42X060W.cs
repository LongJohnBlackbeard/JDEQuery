using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X060W - .
/// </summary>
public class F42X060W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DCSNKY.
        /// </summary>
        public const string DCSNKY = "DCSNKY";

        /// <summary>
        /// DCLNIX.
        /// </summary>
        public const string DCLNIX = "DCLNIX";

        /// <summary>
        /// DCOSEQ.
        /// </summary>
        public const string DCOSEQ = "DCOSEQ";

        /// <summary>
        /// DCITM.
        /// </summary>
        public const string DCITM = "DCITM";

        /// <summary>
        /// DCMMCU.
        /// </summary>
        public const string DCMMCU = "DCMMCU";

        /// <summary>
        /// DC42XDFSDT.
        /// </summary>
        public const string DC42XDFSDT = "DC42XDFSDT";

        /// <summary>
        /// DC42XSM.
        /// </summary>
        public const string DC42XSM = "DC42XSM";

        /// <summary>
        /// DC42XBSN.
        /// </summary>
        public const string DC42XBSN = "DC42XBSN";

        /// <summary>
        /// DC42XBSS.
        /// </summary>
        public const string DC42XBSS = "DC42XBSS";

        /// <summary>
        /// DC42XCDFH.
        /// </summary>
        public const string DC42XCDFH = "DC42XCDFH";

        /// <summary>
        /// DC42XCDFM.
        /// </summary>
        public const string DC42XCDFM = "DC42XCDFM";

        /// <summary>
        /// DC42XCDFL.
        /// </summary>
        public const string DC42XCDFL = "DC42XCDFL";

        /// <summary>
        /// DC42XDFH.
        /// </summary>
        public const string DC42XDFH = "DC42XDFH";

        /// <summary>
        /// DC42XDFM.
        /// </summary>
        public const string DC42XDFM = "DC42XDFM";

        /// <summary>
        /// DC42XDFL.
        /// </summary>
        public const string DC42XDFL = "DC42XDFL";

        /// <summary>
        /// DC42XESN.
        /// </summary>
        public const string DC42XESN = "DC42XESN";

        /// <summary>
        /// DC42XESS.
        /// </summary>
        public const string DC42XESS = "DC42XESS";

        /// <summary>
        /// DCQAVAL.
        /// </summary>
        public const string DCQAVAL = "DCQAVAL";

        /// <summary>
        /// DCPDDJ.
        /// </summary>
        public const string DCPDDJ = "DCPDDJ";

        /// <summary>
        /// DCUORG.
        /// </summary>
        public const string DCUORG = "DCUORG";

        /// <summary>
        /// DCUOM.
        /// </summary>
        public const string DCUOM = "DCUOM";

        /// <summary>
        /// DCUSER.
        /// </summary>
        public const string DCUSER = "DCUSER";

        /// <summary>
        /// DCPID.
        /// </summary>
        public const string DCPID = "DCPID";

        /// <summary>
        /// DCUPMJ.
        /// </summary>
        public const string DCUPMJ = "DCUPMJ";

        /// <summary>
        /// DCUPMT.
        /// </summary>
        public const string DCUPMT = "DCUPMT";

        /// <summary>
        /// DCJOBN.
        /// </summary>
        public const string DCJOBN = "DCJOBN";

        /// <summary>
        /// DCOSCORE.
        /// </summary>
        public const string DCOSCORE = "DCOSCORE";

        /// <summary>
        /// DCSOQS.
        /// </summary>
        public const string DCSOQS = "DCSOQS";

        /// <summary>
        /// DC42XSCORE.
        /// </summary>
        public const string DC42XSCORE = "DC42XSCORE";

        /// <summary>
        /// DCOPPJ.
        /// </summary>
        public const string DCOPPJ = "DCOPPJ";

        /// <summary>
        /// DCQTOR.
        /// </summary>
        public const string DCQTOR = "DCQTOR";

        /// <summary>
        /// DCCOMM.
        /// </summary>
        public const string DCCOMM = "DCCOMM";
    }

    /// <inheritdoc />
    public override string TableName => "F42X060W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DCSNKY", "DCSNKY", JdeDataType.String, 64, true, true),
        new JdeField("DCLNIX", "DCLNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("DCOSEQ", "DCOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DCITM", "DCITM", JdeDataType.Numeric),
        new JdeField("DCMMCU", "DCMMCU", JdeDataType.String, 24),
        new JdeField("DC42XDFSDT", "DC42XDFSDT", JdeDataType.String, 2),
        new JdeField("DC42XSM", "DC42XSM", JdeDataType.String, 2),
        new JdeField("DC42XBSN", "DC42XBSN", JdeDataType.Numeric),
        new JdeField("DC42XBSS", "DC42XBSS", JdeDataType.String, 30),
        new JdeField("DC42XCDFH", "DC42XCDFH", JdeDataType.Numeric),
        new JdeField("DC42XCDFM", "DC42XCDFM", JdeDataType.Numeric),
        new JdeField("DC42XCDFL", "DC42XCDFL", JdeDataType.Numeric),
        new JdeField("DC42XDFH", "DC42XDFH", JdeDataType.Numeric),
        new JdeField("DC42XDFM", "DC42XDFM", JdeDataType.Numeric),
        new JdeField("DC42XDFL", "DC42XDFL", JdeDataType.Numeric),
        new JdeField("DC42XESN", "DC42XESN", JdeDataType.Numeric),
        new JdeField("DC42XESS", "DC42XESS", JdeDataType.String, 30),
        new JdeField("DCQAVAL", "DCQAVAL", JdeDataType.Numeric),
        new JdeField("DCPDDJ", "DCPDDJ", JdeDataType.Numeric),
        new JdeField("DCUORG", "DCUORG", JdeDataType.Numeric),
        new JdeField("DCUOM", "DCUOM", JdeDataType.String, 4),
        new JdeField("DCUSER", "DCUSER", JdeDataType.String, 20),
        new JdeField("DCPID", "DCPID", JdeDataType.String, 20),
        new JdeField("DCUPMJ", "DCUPMJ", JdeDataType.Numeric),
        new JdeField("DCUPMT", "DCUPMT", JdeDataType.Numeric),
        new JdeField("DCJOBN", "DCJOBN", JdeDataType.String, 20),
        new JdeField("DCOSCORE", "DCOSCORE", JdeDataType.Numeric),
        new JdeField("DCSOQS", "DCSOQS", JdeDataType.Numeric),
        new JdeField("DC42XSCORE", "DC42XSCORE", JdeDataType.Numeric),
        new JdeField("DCOPPJ", "DCOPPJ", JdeDataType.Numeric),
        new JdeField("DCQTOR", "DCQTOR", JdeDataType.Numeric),
        new JdeField("DCCOMM", "DCCOMM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X060W_0", "Primary Key on DCSNKY, DCLNIX, DCOSEQ", new[] { "DCSNKY", "DCLNIX", "DCOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42X060W_2", "Index on DCSNKY, DCLNIX, DC42XDFSDT, DCPDDJ", new[] { "DCSNKY", "DCLNIX", "DC42XDFSDT", "DCPDDJ" }),
        new JdeIndex("F42X060W_3", "Index on DCSNKY, DCITM, DCMMCU", new[] { "DCSNKY", "DCITM", "DCMMCU" })
    };
}
