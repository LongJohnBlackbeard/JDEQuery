using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI95 - .
/// </summary>
public class F75IUI95 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCMATC.
        /// </summary>
        public const string RCMATC = "RCMATC";

        /// <summary>
        /// RCDOCO.
        /// </summary>
        public const string RCDOCO = "RCDOCO";

        /// <summary>
        /// RCDCTO.
        /// </summary>
        public const string RCDCTO = "RCDCTO";

        /// <summary>
        /// RCKCOO.
        /// </summary>
        public const string RCKCOO = "RCKCOO";

        /// <summary>
        /// RCSFXO.
        /// </summary>
        public const string RCSFXO = "RCSFXO";

        /// <summary>
        /// RCLNID.
        /// </summary>
        public const string RCLNID = "RCLNID";

        /// <summary>
        /// RCNLIN.
        /// </summary>
        public const string RCNLIN = "RCNLIN";

        /// <summary>
        /// RCJOBS.
        /// </summary>
        public const string RCJOBS = "RCJOBS";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCSEQ.
        /// </summary>
        public const string RCSEQ = "RCSEQ";

        /// <summary>
        /// RCTYC.
        /// </summary>
        public const string RCTYC = "RCTYC";

        /// <summary>
        /// RCCRCD.
        /// </summary>
        public const string RCCRCD = "RCCRCD";

        /// <summary>
        /// RCAN8.
        /// </summary>
        public const string RCAN8 = "RCAN8";

        /// <summary>
        /// RCLVLA.
        /// </summary>
        public const string RCLVLA = "RCLVLA";

        /// <summary>
        /// RCI75GSTR.
        /// </summary>
        public const string RCI75GSTR = "RCI75GSTR";

        /// <summary>
        /// RCI75TXTY.
        /// </summary>
        public const string RCI75TXTY = "RCI75TXTY";

        /// <summary>
        /// RCUORGE1.
        /// </summary>
        public const string RCUORGE1 = "RCUORGE1";

        /// <summary>
        /// RCUPAX.
        /// </summary>
        public const string RCUPAX = "RCUPAX";

        /// <summary>
        /// RCAEXPE1.
        /// </summary>
        public const string RCAEXPE1 = "RCAEXPE1";

        /// <summary>
        /// RCI75PSP.
        /// </summary>
        public const string RCI75PSP = "RCI75PSP";

        /// <summary>
        /// RCI75PSR.
        /// </summary>
        public const string RCI75PSR = "RCI75PSR";

        /// <summary>
        /// RCI75PROVL.
        /// </summary>
        public const string RCI75PROVL = "RCI75PROVL";

        /// <summary>
        /// RCI75RECVL.
        /// </summary>
        public const string RCI75RECVL = "RCI75RECVL";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCUPMT.
        /// </summary>
        public const string RCUPMT = "RCUPMT";

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
        /// RCATXA.
        /// </summary>
        public const string RCATXA = "RCATXA";

        /// <summary>
        /// RCUITM.
        /// </summary>
        public const string RCUITM = "RCUITM";

        /// <summary>
        /// RCUORG.
        /// </summary>
        public const string RCUORG = "RCUORG";

        /// <summary>
        /// RCUOM.
        /// </summary>
        public const string RCUOM = "RCUOM";

        /// <summary>
        /// RCRMK.
        /// </summary>
        public const string RCRMK = "RCRMK";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI95";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCMATC", "RCMATC", JdeDataType.String, 2, true, true),
        new JdeField("RCDOCO", "RCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RCDCTO", "RCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RCKCOO", "RCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RCSFXO", "RCSFXO", JdeDataType.String, 6, true, true),
        new JdeField("RCLNID", "RCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RCNLIN", "RCNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("RCJOBS", "RCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20, true, true),
        new JdeField("RCSEQ", "RCSEQ", JdeDataType.Numeric),
        new JdeField("RCTYC", "RCTYC", JdeDataType.String, 2),
        new JdeField("RCCRCD", "RCCRCD", JdeDataType.String, 6),
        new JdeField("RCAN8", "RCAN8", JdeDataType.Numeric),
        new JdeField("RCLVLA", "RCLVLA", JdeDataType.String, 6),
        new JdeField("RCI75GSTR", "RCI75GSTR", JdeDataType.Numeric),
        new JdeField("RCI75TXTY", "RCI75TXTY", JdeDataType.String, 10),
        new JdeField("RCUORGE1", "RCUORGE1", JdeDataType.Numeric),
        new JdeField("RCUPAX", "RCUPAX", JdeDataType.Numeric),
        new JdeField("RCAEXPE1", "RCAEXPE1", JdeDataType.Numeric),
        new JdeField("RCI75PSP", "RCI75PSP", JdeDataType.Numeric),
        new JdeField("RCI75PSR", "RCI75PSR", JdeDataType.Numeric),
        new JdeField("RCI75PROVL", "RCI75PROVL", JdeDataType.Numeric),
        new JdeField("RCI75RECVL", "RCI75RECVL", JdeDataType.Numeric),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCUPMT", "RCUPMT", JdeDataType.Numeric),
        new JdeField("RCYFUTDT1", "RCYFUTDT1", JdeDataType.Numeric),
        new JdeField("RCFUT6", "RCFUT6", JdeDataType.String, 60),
        new JdeField("RCYT04", "RCYT04", JdeDataType.String, 2),
        new JdeField("RCYFLAG", "RCYFLAG", JdeDataType.String, 2),
        new JdeField("RCYNUM1", "RCYNUM1", JdeDataType.Numeric),
        new JdeField("RCATXA", "RCATXA", JdeDataType.Numeric),
        new JdeField("RCUITM", "RCUITM", JdeDataType.String, 52),
        new JdeField("RCUORG", "RCUORG", JdeDataType.Numeric),
        new JdeField("RCUOM", "RCUOM", JdeDataType.String, 4),
        new JdeField("RCRMK", "RCRMK", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI95_0", "Primary Key on RCMATC, RCDOCO, RCDCTO, RCKCOO, RCSFXO, RCLNID, RCNLIN, RCJOBS, RCUSER", new[] { "RCMATC", "RCDOCO", "RCDCTO", "RCKCOO", "RCSFXO", "RCLNID", "RCNLIN", "RCJOBS", "RCUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
