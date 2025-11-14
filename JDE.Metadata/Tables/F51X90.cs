using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51X90 - .
/// </summary>
public class F51X90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// X151XCOLN.
        /// </summary>
        public const string X151XCOLN = "X151XCOLN";

        /// <summary>
        /// X1DL01.
        /// </summary>
        public const string X1DL01 = "X1DL01";

        /// <summary>
        /// X151XCLT.
        /// </summary>
        public const string X151XCLT = "X151XCLT";

        /// <summary>
        /// X151XCLH.
        /// </summary>
        public const string X151XCLH = "X151XCLH";

        /// <summary>
        /// X1LT.
        /// </summary>
        public const string X1LT = "X1LT";

        /// <summary>
        /// X151XHUN.
        /// </summary>
        public const string X151XHUN = "X151XHUN";

        /// <summary>
        /// X151XBDG.
        /// </summary>
        public const string X151XBDG = "X151XBDG";

        /// <summary>
        /// X151XBILL.
        /// </summary>
        public const string X151XBILL = "X151XBILL";

        /// <summary>
        /// X151XDP.
        /// </summary>
        public const string X151XDP = "X151XDP";

        /// <summary>
        /// X151XUOA.
        /// </summary>
        public const string X151XUOA = "X151XUOA";

        /// <summary>
        /// X151XBF.
        /// </summary>
        public const string X151XBF = "X151XBF";

        /// <summary>
        /// X151XFMLA.
        /// </summary>
        public const string X151XFMLA = "X151XFMLA";

        /// <summary>
        /// X151XFS1.
        /// </summary>
        public const string X151XFS1 = "X151XFS1";

        /// <summary>
        /// X151XFS2.
        /// </summary>
        public const string X151XFS2 = "X151XFS2";

        /// <summary>
        /// X151XFS3.
        /// </summary>
        public const string X151XFS3 = "X151XFS3";

        /// <summary>
        /// X151XFS4.
        /// </summary>
        public const string X151XFS4 = "X151XFS4";

        /// <summary>
        /// X151XFS5.
        /// </summary>
        public const string X151XFS5 = "X151XFS5";

        /// <summary>
        /// X151XFS6.
        /// </summary>
        public const string X151XFS6 = "X151XFS6";

        /// <summary>
        /// X151XFS7.
        /// </summary>
        public const string X151XFS7 = "X151XFS7";

        /// <summary>
        /// X151XFS8.
        /// </summary>
        public const string X151XFS8 = "X151XFS8";

        /// <summary>
        /// X151XFS9.
        /// </summary>
        public const string X151XFS9 = "X151XFS9";

        /// <summary>
        /// X151XFS10.
        /// </summary>
        public const string X151XFS10 = "X151XFS10";

        /// <summary>
        /// X151XFF1.
        /// </summary>
        public const string X151XFF1 = "X151XFF1";

        /// <summary>
        /// X151XFF2.
        /// </summary>
        public const string X151XFF2 = "X151XFF2";

        /// <summary>
        /// X151XFF3.
        /// </summary>
        public const string X151XFF3 = "X151XFF3";

        /// <summary>
        /// X151XFF4.
        /// </summary>
        public const string X151XFF4 = "X151XFF4";

        /// <summary>
        /// X151XFF5.
        /// </summary>
        public const string X151XFF5 = "X151XFF5";

        /// <summary>
        /// X151XFF6.
        /// </summary>
        public const string X151XFF6 = "X151XFF6";

        /// <summary>
        /// X151XFF7.
        /// </summary>
        public const string X151XFF7 = "X151XFF7";

        /// <summary>
        /// X151XFF8.
        /// </summary>
        public const string X151XFF8 = "X151XFF8";

        /// <summary>
        /// X151XFF9.
        /// </summary>
        public const string X151XFF9 = "X151XFF9";

        /// <summary>
        /// X151XFT1.
        /// </summary>
        public const string X151XFT1 = "X151XFT1";

        /// <summary>
        /// X151XFT2.
        /// </summary>
        public const string X151XFT2 = "X151XFT2";

        /// <summary>
        /// X151XFT3.
        /// </summary>
        public const string X151XFT3 = "X151XFT3";

        /// <summary>
        /// X151XFT4.
        /// </summary>
        public const string X151XFT4 = "X151XFT4";

        /// <summary>
        /// X151XFT5.
        /// </summary>
        public const string X151XFT5 = "X151XFT5";

        /// <summary>
        /// X151XFT6.
        /// </summary>
        public const string X151XFT6 = "X151XFT6";

        /// <summary>
        /// X151XFT7.
        /// </summary>
        public const string X151XFT7 = "X151XFT7";

        /// <summary>
        /// X151XFT8.
        /// </summary>
        public const string X151XFT8 = "X151XFT8";

        /// <summary>
        /// X151XFT9.
        /// </summary>
        public const string X151XFT9 = "X151XFT9";

        /// <summary>
        /// X151XFT10.
        /// </summary>
        public const string X151XFT10 = "X151XFT10";

        /// <summary>
        /// X1MLTP.
        /// </summary>
        public const string X1MLTP = "X1MLTP";

        /// <summary>
        /// X1DITM.
        /// </summary>
        public const string X1DITM = "X1DITM";

        /// <summary>
        /// X1DCML.
        /// </summary>
        public const string X1DCML = "X1DCML";

        /// <summary>
        /// X1EC.
        /// </summary>
        public const string X1EC = "X1EC";

        /// <summary>
        /// X1USER.
        /// </summary>
        public const string X1USER = "X1USER";

        /// <summary>
        /// X1PID.
        /// </summary>
        public const string X1PID = "X1PID";

        /// <summary>
        /// X1JOBN.
        /// </summary>
        public const string X1JOBN = "X1JOBN";

        /// <summary>
        /// X1UPMJ.
        /// </summary>
        public const string X1UPMJ = "X1UPMJ";

        /// <summary>
        /// X1UPMT.
        /// </summary>
        public const string X1UPMT = "X1UPMT";

        /// <summary>
        /// X151XTM.
        /// </summary>
        public const string X151XTM = "X151XTM";

        /// <summary>
        /// X151XAIC.
        /// </summary>
        public const string X151XAIC = "X151XAIC";

        /// <summary>
        /// X151XDDO.
        /// </summary>
        public const string X151XDDO = "X151XDDO";

        /// <summary>
        /// X151XABC.
        /// </summary>
        public const string X151XABC = "X151XABC";

        /// <summary>
        /// X151XAT1.
        /// </summary>
        public const string X151XAT1 = "X151XAT1";

        /// <summary>
        /// X151XAT2.
        /// </summary>
        public const string X151XAT2 = "X151XAT2";

        /// <summary>
        /// X151XAT3.
        /// </summary>
        public const string X151XAT3 = "X151XAT3";

        /// <summary>
        /// X151XARN.
        /// </summary>
        public const string X151XARN = "X151XARN";

        /// <summary>
        /// X151XAOP.
        /// </summary>
        public const string X151XAOP = "X151XAOP";

        /// <summary>
        /// X151XTCC.
        /// </summary>
        public const string X151XTCC = "X151XTCC";
    }

    /// <inheritdoc />
    public override string TableName => "F51X90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("X151XCOLN", "X151XCOLN", JdeDataType.String, 12, true, true),
        new JdeField("X1DL01", "X1DL01", JdeDataType.String, 60),
        new JdeField("X151XCLT", "X151XCLT", JdeDataType.String, 2),
        new JdeField("X151XCLH", "X151XCLH", JdeDataType.String, 80),
        new JdeField("X1LT", "X1LT", JdeDataType.String, 4),
        new JdeField("X151XHUN", "X151XHUN", JdeDataType.String, 2),
        new JdeField("X151XBDG", "X151XBDG", JdeDataType.String, 2),
        new JdeField("X151XBILL", "X151XBILL", JdeDataType.String, 4),
        new JdeField("X151XDP", "X151XDP", JdeDataType.Numeric),
        new JdeField("X151XUOA", "X151XUOA", JdeDataType.String, 2),
        new JdeField("X151XBF", "X151XBF", JdeDataType.String, 2),
        new JdeField("X151XFMLA", "X151XFMLA", JdeDataType.String, 160),
        new JdeField("X151XFS1", "X151XFS1", JdeDataType.String, 12),
        new JdeField("X151XFS2", "X151XFS2", JdeDataType.String, 12),
        new JdeField("X151XFS3", "X151XFS3", JdeDataType.String, 12),
        new JdeField("X151XFS4", "X151XFS4", JdeDataType.String, 12),
        new JdeField("X151XFS5", "X151XFS5", JdeDataType.String, 12),
        new JdeField("X151XFS6", "X151XFS6", JdeDataType.String, 12),
        new JdeField("X151XFS7", "X151XFS7", JdeDataType.String, 12),
        new JdeField("X151XFS8", "X151XFS8", JdeDataType.String, 12),
        new JdeField("X151XFS9", "X151XFS9", JdeDataType.String, 12),
        new JdeField("X151XFS10", "X151XFS10", JdeDataType.String, 12),
        new JdeField("X151XFF1", "X151XFF1", JdeDataType.String, 2),
        new JdeField("X151XFF2", "X151XFF2", JdeDataType.String, 2),
        new JdeField("X151XFF3", "X151XFF3", JdeDataType.String, 2),
        new JdeField("X151XFF4", "X151XFF4", JdeDataType.String, 2),
        new JdeField("X151XFF5", "X151XFF5", JdeDataType.String, 2),
        new JdeField("X151XFF6", "X151XFF6", JdeDataType.String, 2),
        new JdeField("X151XFF7", "X151XFF7", JdeDataType.String, 2),
        new JdeField("X151XFF8", "X151XFF8", JdeDataType.String, 2),
        new JdeField("X151XFF9", "X151XFF9", JdeDataType.String, 2),
        new JdeField("X151XFT1", "X151XFT1", JdeDataType.String, 2),
        new JdeField("X151XFT2", "X151XFT2", JdeDataType.String, 2),
        new JdeField("X151XFT3", "X151XFT3", JdeDataType.String, 2),
        new JdeField("X151XFT4", "X151XFT4", JdeDataType.String, 2),
        new JdeField("X151XFT5", "X151XFT5", JdeDataType.String, 2),
        new JdeField("X151XFT6", "X151XFT6", JdeDataType.String, 2),
        new JdeField("X151XFT7", "X151XFT7", JdeDataType.String, 2),
        new JdeField("X151XFT8", "X151XFT8", JdeDataType.String, 2),
        new JdeField("X151XFT9", "X151XFT9", JdeDataType.String, 2),
        new JdeField("X151XFT10", "X151XFT10", JdeDataType.String, 2),
        new JdeField("X1MLTP", "X1MLTP", JdeDataType.Numeric),
        new JdeField("X1DITM", "X1DITM", JdeDataType.String, 20),
        new JdeField("X1DCML", "X1DCML", JdeDataType.Numeric),
        new JdeField("X1EC", "X1EC", JdeDataType.String, 2),
        new JdeField("X1USER", "X1USER", JdeDataType.String, 20),
        new JdeField("X1PID", "X1PID", JdeDataType.String, 20),
        new JdeField("X1JOBN", "X1JOBN", JdeDataType.String, 20),
        new JdeField("X1UPMJ", "X1UPMJ", JdeDataType.Numeric),
        new JdeField("X1UPMT", "X1UPMT", JdeDataType.Numeric),
        new JdeField("X151XTM", "X151XTM", JdeDataType.String, 2),
        new JdeField("X151XAIC", "X151XAIC", JdeDataType.String, 2),
        new JdeField("X151XDDO", "X151XDDO", JdeDataType.String, 2),
        new JdeField("X151XABC", "X151XABC", JdeDataType.String, 12),
        new JdeField("X151XAT1", "X151XAT1", JdeDataType.Numeric),
        new JdeField("X151XAT2", "X151XAT2", JdeDataType.Numeric),
        new JdeField("X151XAT3", "X151XAT3", JdeDataType.Numeric),
        new JdeField("X151XARN", "X151XARN", JdeDataType.String, 12),
        new JdeField("X151XAOP", "X151XAOP", JdeDataType.String, 2),
        new JdeField("X151XTCC", "X151XTCC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51X90_0", "Primary Key on X151XCOLN", new[] { "X151XCOLN" }, isUnique: true, isPrimaryKey: true)
    };
}
