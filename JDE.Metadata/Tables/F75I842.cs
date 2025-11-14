using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I842 - .
/// </summary>
public class F75I842 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCKCOO.
        /// </summary>
        public const string RCKCOO = "RCKCOO";

        /// <summary>
        /// RCDOCO.
        /// </summary>
        public const string RCDOCO = "RCDOCO";

        /// <summary>
        /// RCDCTO.
        /// </summary>
        public const string RCDCTO = "RCDCTO";

        /// <summary>
        /// RCLNID.
        /// </summary>
        public const string RCLNID = "RCLNID";

        /// <summary>
        /// RCI75TXTY.
        /// </summary>
        public const string RCI75TXTY = "RCI75TXTY";

        /// <summary>
        /// RCASN.
        /// </summary>
        public const string RCASN = "RCASN";

        /// <summary>
        /// RCAST.
        /// </summary>
        public const string RCAST = "RCAST";

        /// <summary>
        /// RCI75TXRL.
        /// </summary>
        public const string RCI75TXRL = "RCI75TXRL";

        /// <summary>
        /// RCI75TXRG.
        /// </summary>
        public const string RCI75TXRG = "RCI75TXRG";

        /// <summary>
        /// RCI75GSTR.
        /// </summary>
        public const string RCI75GSTR = "RCI75GSTR";

        /// <summary>
        /// RCI75PSP.
        /// </summary>
        public const string RCI75PSP = "RCI75PSP";

        /// <summary>
        /// RCI75PSR.
        /// </summary>
        public const string RCI75PSR = "RCI75PSR";

        /// <summary>
        /// RCI75FRC.
        /// </summary>
        public const string RCI75FRC = "RCI75FRC";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCUPMT.
        /// </summary>
        public const string RCUPMT = "RCUPMT";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";

        /// <summary>
        /// RCCRR.
        /// </summary>
        public const string RCCRR = "RCCRR";

        /// <summary>
        /// RCCRCD.
        /// </summary>
        public const string RCCRCD = "RCCRCD";

        /// <summary>
        /// RCAKID.
        /// </summary>
        public const string RCAKID = "RCAKID";

        /// <summary>
        /// RCSRCFD.
        /// </summary>
        public const string RCSRCFD = "RCSRCFD";

        /// <summary>
        /// RCOSEQ.
        /// </summary>
        public const string RCOSEQ = "RCOSEQ";

        /// <summary>
        /// RCSUBSEQ.
        /// </summary>
        public const string RCSUBSEQ = "RCSUBSEQ";

        /// <summary>
        /// RCTIER.
        /// </summary>
        public const string RCTIER = "RCTIER";

        /// <summary>
        /// RCPA04.
        /// </summary>
        public const string RCPA04 = "RCPA04";

        /// <summary>
        /// RCYFUTDT1.
        /// </summary>
        public const string RCYFUTDT1 = "RCYFUTDT1";

        /// <summary>
        /// RCFUT6.
        /// </summary>
        public const string RCFUT6 = "RCFUT6";

        /// <summary>
        /// RCYT04.
        /// </summary>
        public const string RCYT04 = "RCYT04";

        /// <summary>
        /// RCYFLAG.
        /// </summary>
        public const string RCYFLAG = "RCYFLAG";

        /// <summary>
        /// RCYNUM1.
        /// </summary>
        public const string RCYNUM1 = "RCYNUM1";

        /// <summary>
        /// RCSTAM4.
        /// </summary>
        public const string RCSTAM4 = "RCSTAM4";

        /// <summary>
        /// RCI75PRVL4.
        /// </summary>
        public const string RCI75PRVL4 = "RCI75PRVL4";

        /// <summary>
        /// RCI75REVL4.
        /// </summary>
        public const string RCI75REVL4 = "RCI75REVL4";
    }

    /// <inheritdoc />
    public override string TableName => "F75I842";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCKCOO", "RCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RCDOCO", "RCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RCDCTO", "RCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RCLNID", "RCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RCI75TXTY", "RCI75TXTY", JdeDataType.String, 10),
        new JdeField("RCASN", "RCASN", JdeDataType.String, 16, true, true),
        new JdeField("RCAST", "RCAST", JdeDataType.String, 16, true, true),
        new JdeField("RCI75TXRL", "RCI75TXRL", JdeDataType.String, 12),
        new JdeField("RCI75TXRG", "RCI75TXRG", JdeDataType.String, 10),
        new JdeField("RCI75GSTR", "RCI75GSTR", JdeDataType.Numeric),
        new JdeField("RCI75PSP", "RCI75PSP", JdeDataType.Numeric),
        new JdeField("RCI75PSR", "RCI75PSR", JdeDataType.Numeric),
        new JdeField("RCI75FRC", "RCI75FRC", JdeDataType.String, 2),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCUPMT", "RCUPMT", JdeDataType.Numeric),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCCRR", "RCCRR", JdeDataType.Numeric),
        new JdeField("RCCRCD", "RCCRCD", JdeDataType.String, 6),
        new JdeField("RCAKID", "RCAKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RCSRCFD", "RCSRCFD", JdeDataType.String, 4, true, true),
        new JdeField("RCOSEQ", "RCOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RCSUBSEQ", "RCSUBSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RCTIER", "RCTIER", JdeDataType.Numeric, null, true, true),
        new JdeField("RCPA04", "RCPA04", JdeDataType.String, 2, true, true),
        new JdeField("RCYFUTDT1", "RCYFUTDT1", JdeDataType.Numeric),
        new JdeField("RCFUT6", "RCFUT6", JdeDataType.String, 60),
        new JdeField("RCYT04", "RCYT04", JdeDataType.String, 2),
        new JdeField("RCYFLAG", "RCYFLAG", JdeDataType.String, 2),
        new JdeField("RCYNUM1", "RCYNUM1", JdeDataType.Numeric),
        new JdeField("RCSTAM4", "RCSTAM4", JdeDataType.Numeric),
        new JdeField("RCI75PRVL4", "RCI75PRVL4", JdeDataType.Numeric),
        new JdeField("RCI75REVL4", "RCI75REVL4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I842_0", "Primary Key on RCKCOO, RCDOCO, RCDCTO, RCLNID, RCASN, RCAST, RCAKID, RCSRCFD, RCOSEQ, RCSUBSEQ, RCTIER, RCPA04", new[] { "RCKCOO", "RCDOCO", "RCDCTO", "RCLNID", "RCASN", "RCAST", "RCAKID", "RCSRCFD", "RCOSEQ", "RCSUBSEQ", "RCTIER", "RCPA04" }, isUnique: true, isPrimaryKey: true)
    };
}
