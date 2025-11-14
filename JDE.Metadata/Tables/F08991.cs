using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08991 - .
/// </summary>
public class F08991 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HDCO.
        /// </summary>
        public const string HDCO = "HDCO";

        /// <summary>
        /// HDQE1.
        /// </summary>
        public const string HDQE1 = "HDQE1";

        /// <summary>
        /// HDQET.
        /// </summary>
        public const string HDQET = "HDQET";

        /// <summary>
        /// HDTARR.
        /// </summary>
        public const string HDTARR = "HDTARR";

        /// <summary>
        /// HDHMCU.
        /// </summary>
        public const string HDHMCU = "HDHMCU";

        /// <summary>
        /// HDEFTE.
        /// </summary>
        public const string HDEFTE = "HDEFTE";

        /// <summary>
        /// HDEFTB.
        /// </summary>
        public const string HDEFTB = "HDEFTB";

        /// <summary>
        /// HDRCCP.
        /// </summary>
        public const string HDRCCP = "HDRCCP";

        /// <summary>
        /// HDRCF.
        /// </summary>
        public const string HDRCF = "HDRCF";

        /// <summary>
        /// HDDCCP.
        /// </summary>
        public const string HDDCCP = "HDDCCP";

        /// <summary>
        /// HDDCF.
        /// </summary>
        public const string HDDCF = "HDDCF";

        /// <summary>
        /// HDSCCP.
        /// </summary>
        public const string HDSCCP = "HDSCCP";

        /// <summary>
        /// HDSCF.
        /// </summary>
        public const string HDSCF = "HDSCF";

        /// <summary>
        /// HDAFRA.
        /// </summary>
        public const string HDAFRA = "HDAFRA";

        /// <summary>
        /// HDAFR.
        /// </summary>
        public const string HDAFR = "HDAFR";

        /// <summary>
        /// HDAFDA.
        /// </summary>
        public const string HDAFDA = "HDAFDA";

        /// <summary>
        /// HDAFD.
        /// </summary>
        public const string HDAFD = "HDAFD";

        /// <summary>
        /// HDAFSA.
        /// </summary>
        public const string HDAFSA = "HDAFSA";

        /// <summary>
        /// HDAFS.
        /// </summary>
        public const string HDAFS = "HDAFS";

        /// <summary>
        /// HDCFC.
        /// </summary>
        public const string HDCFC = "HDCFC";

        /// <summary>
        /// HDCFCM.
        /// </summary>
        public const string HDCFCM = "HDCFCM";

        /// <summary>
        /// HDELCP.
        /// </summary>
        public const string HDELCP = "HDELCP";

        /// <summary>
        /// HDELPF.
        /// </summary>
        public const string HDELPF = "HDELPF";

        /// <summary>
        /// HDGRCI.
        /// </summary>
        public const string HDGRCI = "HDGRCI";

        /// <summary>
        /// HDINPF.
        /// </summary>
        public const string HDINPF = "HDINPF";

        /// <summary>
        /// HDFCPR.
        /// </summary>
        public const string HDFCPR = "HDFCPR";

        /// <summary>
        /// HDCV.
        /// </summary>
        public const string HDCV = "HDCV";

        /// <summary>
        /// HDSNDLTR.
        /// </summary>
        public const string HDSNDLTR = "HDSNDLTR";

        /// <summary>
        /// HDUSER.
        /// </summary>
        public const string HDUSER = "HDUSER";

        /// <summary>
        /// HDEAP.
        /// </summary>
        public const string HDEAP = "HDEAP";

        /// <summary>
        /// HDMACH.
        /// </summary>
        public const string HDMACH = "HDMACH";

        /// <summary>
        /// HDUPMJ.
        /// </summary>
        public const string HDUPMJ = "HDUPMJ";

        /// <summary>
        /// HDUPMT.
        /// </summary>
        public const string HDUPMT = "HDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08991";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HDCO", "HDCO", JdeDataType.String, 10, true, true),
        new JdeField("HDQE1", "HDQE1", JdeDataType.String, 4, true, true),
        new JdeField("HDQET", "HDQET", JdeDataType.String, 2),
        new JdeField("HDTARR", "HDTARR", JdeDataType.String, 20, true, true),
        new JdeField("HDHMCU", "HDHMCU", JdeDataType.String, 24, true, true),
        new JdeField("HDEFTE", "HDEFTE", JdeDataType.Numeric),
        new JdeField("HDEFTB", "HDEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("HDRCCP", "HDRCCP", JdeDataType.Numeric),
        new JdeField("HDRCF", "HDRCF", JdeDataType.String, 2),
        new JdeField("HDDCCP", "HDDCCP", JdeDataType.Numeric),
        new JdeField("HDDCF", "HDDCF", JdeDataType.String, 2),
        new JdeField("HDSCCP", "HDSCCP", JdeDataType.Numeric),
        new JdeField("HDSCF", "HDSCF", JdeDataType.String, 2),
        new JdeField("HDAFRA", "HDAFRA", JdeDataType.Numeric),
        new JdeField("HDAFR", "HDAFR", JdeDataType.String, 2),
        new JdeField("HDAFDA", "HDAFDA", JdeDataType.Numeric),
        new JdeField("HDAFD", "HDAFD", JdeDataType.String, 2),
        new JdeField("HDAFSA", "HDAFSA", JdeDataType.Numeric),
        new JdeField("HDAFS", "HDAFS", JdeDataType.String, 2),
        new JdeField("HDCFC", "HDCFC", JdeDataType.Numeric),
        new JdeField("HDCFCM", "HDCFCM", JdeDataType.String, 2),
        new JdeField("HDELCP", "HDELCP", JdeDataType.Numeric),
        new JdeField("HDELPF", "HDELPF", JdeDataType.String, 2),
        new JdeField("HDGRCI", "HDGRCI", JdeDataType.Numeric),
        new JdeField("HDINPF", "HDINPF", JdeDataType.String, 2),
        new JdeField("HDFCPR", "HDFCPR", JdeDataType.String, 2),
        new JdeField("HDCV", "HDCV", JdeDataType.String, 2),
        new JdeField("HDSNDLTR", "HDSNDLTR", JdeDataType.String, 2),
        new JdeField("HDUSER", "HDUSER", JdeDataType.String, 20),
        new JdeField("HDEAP", "HDEAP", JdeDataType.String, 20),
        new JdeField("HDMACH", "HDMACH", JdeDataType.String, 24),
        new JdeField("HDUPMJ", "HDUPMJ", JdeDataType.Numeric),
        new JdeField("HDUPMT", "HDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08991_0", "Primary Key on HDCO, HDQE1, HDHMCU, HDTARR, HDEFTB", new[] { "HDCO", "HDQE1", "HDHMCU", "HDTARR", "HDEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08991_2", "Index on HDCO, HDQE1, HDTARR, HDEFTB, HDEFTE", new[] { "HDCO", "HDQE1", "HDTARR", "HDEFTB", "HDEFTE" }),
        new JdeIndex("F08991_3", "Index on HDCO, HDQE1, HDHMCU, HDEFTB, HDEFTE", new[] { "HDCO", "HDQE1", "HDHMCU", "HDEFTB", "HDEFTE" }),
        new JdeIndex("F08991_4", "Index on HDCO, HDQE1, HDEFTB, HDEFTE", new[] { "HDCO", "HDQE1", "HDEFTB", "HDEFTE" }),
        new JdeIndex("F08991_5", "Index on HDCO, HDQE1, HDHMCU, SYS_NC00034$, SYS_NC00035$, HDTARR", new[] { "HDCO", "HDQE1", "HDHMCU", "SYS_NC00034$", "SYS_NC00035$", "HDTARR" })
    };
}
