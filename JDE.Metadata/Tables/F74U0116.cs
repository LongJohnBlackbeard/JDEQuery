using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0116 - .
/// </summary>
public class F74U0116 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFKCO.
        /// </summary>
        public const string TFKCO = "TFKCO";

        /// <summary>
        /// TFDOC.
        /// </summary>
        public const string TFDOC = "TFDOC";

        /// <summary>
        /// TFDCT.
        /// </summary>
        public const string TFDCT = "TFDCT";

        /// <summary>
        /// TFSFX.
        /// </summary>
        public const string TFSFX = "TFSFX";

        /// <summary>
        /// TFSFXE.
        /// </summary>
        public const string TFSFXE = "TFSFXE";

        /// <summary>
        /// TFUKTRDA.
        /// </summary>
        public const string TFUKTRDA = "TFUKTRDA";

        /// <summary>
        /// TFUKACTF.
        /// </summary>
        public const string TFUKACTF = "TFUKACTF";

        /// <summary>
        /// TFUKAUIT.
        /// </summary>
        public const string TFUKAUIT = "TFUKAUIT";

        /// <summary>
        /// TFUKDN.
        /// </summary>
        public const string TFUKDN = "TFUKDN";

        /// <summary>
        /// TFUKCCTY.
        /// </summary>
        public const string TFUKCCTY = "TFUKCCTY";

        /// <summary>
        /// TFUKNTIN.
        /// </summary>
        public const string TFUKNTIN = "TFUKNTIN";

        /// <summary>
        /// TFUKCRN.
        /// </summary>
        public const string TFUKCRN = "TFUKCRN";

        /// <summary>
        /// TFUKTS.
        /// </summary>
        public const string TFUKTS = "TFUKTS";

        /// <summary>
        /// TFUKTVPS.
        /// </summary>
        public const string TFUKTVPS = "TFUKTVPS";

        /// <summary>
        /// TFUKCSPT.
        /// </summary>
        public const string TFUKCSPT = "TFUKCSPT";

        /// <summary>
        /// TFUKVCSR.
        /// </summary>
        public const string TFUKVCSR = "TFUKVCSR";

        /// <summary>
        /// TFUKTSQN.
        /// </summary>
        public const string TFUKTSQN = "TFUKTSQN";

        /// <summary>
        /// TFUKCHQE.
        /// </summary>
        public const string TFUKCHQE = "TFUKCHQE";

        /// <summary>
        /// TFUKCHQD.
        /// </summary>
        public const string TFUKCHQD = "TFUKCHQD";

        /// <summary>
        /// TFUKTAG1.
        /// </summary>
        public const string TFUKTAG1 = "TFUKTAG1";

        /// <summary>
        /// TFUKTAG2.
        /// </summary>
        public const string TFUKTAG2 = "TFUKTAG2";

        /// <summary>
        /// TFUKTAG3.
        /// </summary>
        public const string TFUKTAG3 = "TFUKTAG3";

        /// <summary>
        /// TFUKTAG4.
        /// </summary>
        public const string TFUKTAG4 = "TFUKTAG4";

        /// <summary>
        /// TFUKTAG5.
        /// </summary>
        public const string TFUKTAG5 = "TFUKTAG5";

        /// <summary>
        /// TFUKTAG6.
        /// </summary>
        public const string TFUKTAG6 = "TFUKTAG6";

        /// <summary>
        /// TFUKTAG7.
        /// </summary>
        public const string TFUKTAG7 = "TFUKTAG7";

        /// <summary>
        /// TFUKTAG8.
        /// </summary>
        public const string TFUKTAG8 = "TFUKTAG8";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0116";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFKCO", "TFKCO", JdeDataType.String, 10, true, true),
        new JdeField("TFDOC", "TFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TFDCT", "TFDCT", JdeDataType.String, 4, true, true),
        new JdeField("TFSFX", "TFSFX", JdeDataType.String, 6, true, true),
        new JdeField("TFSFXE", "TFSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("TFUKTRDA", "TFUKTRDA", JdeDataType.Numeric),
        new JdeField("TFUKACTF", "TFUKACTF", JdeDataType.Numeric),
        new JdeField("TFUKAUIT", "TFUKAUIT", JdeDataType.Numeric),
        new JdeField("TFUKDN", "TFUKDN", JdeDataType.String, 26),
        new JdeField("TFUKCCTY", "TFUKCCTY", JdeDataType.String, 20),
        new JdeField("TFUKNTIN", "TFUKNTIN", JdeDataType.String, 18),
        new JdeField("TFUKCRN", "TFUKCRN", JdeDataType.String, 16),
        new JdeField("TFUKTS", "TFUKTS", JdeDataType.String, 2),
        new JdeField("TFUKTVPS", "TFUKTVPS", JdeDataType.String, 2),
        new JdeField("TFUKCSPT", "TFUKCSPT", JdeDataType.Numeric),
        new JdeField("TFUKVCSR", "TFUKVCSR", JdeDataType.String, 20),
        new JdeField("TFUKTSQN", "TFUKTSQN", JdeDataType.String, 20),
        new JdeField("TFUKCHQE", "TFUKCHQE", JdeDataType.Numeric),
        new JdeField("TFUKCHQD", "TFUKCHQD", JdeDataType.Numeric),
        new JdeField("TFUKTAG1", "TFUKTAG1", JdeDataType.String, 2),
        new JdeField("TFUKTAG2", "TFUKTAG2", JdeDataType.Numeric),
        new JdeField("TFUKTAG3", "TFUKTAG3", JdeDataType.Numeric),
        new JdeField("TFUKTAG4", "TFUKTAG4", JdeDataType.String, 20),
        new JdeField("TFUKTAG5", "TFUKTAG5", JdeDataType.String, 60),
        new JdeField("TFUKTAG6", "TFUKTAG6", JdeDataType.Numeric),
        new JdeField("TFUKTAG7", "TFUKTAG7", JdeDataType.Numeric),
        new JdeField("TFUKTAG8", "TFUKTAG8", JdeDataType.Numeric),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0116_0", "Primary Key on TFDOC, TFDCT, TFKCO, TFSFX, TFSFXE", new[] { "TFDOC", "TFDCT", "TFKCO", "TFSFX", "TFSFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0116_2", "Index on TFUKTRDA, TFUKCCTY", new[] { "TFUKTRDA", "TFUKCCTY" }),
        new JdeIndex("F74U0116_3", "Index on TFUKAUIT, TFUKDN, TFUKCCTY", new[] { "TFUKAUIT", "TFUKDN", "TFUKCCTY" }),
        new JdeIndex("F74U0116_4", "Index on TFUKTRDA, TFUKCCTY, TFUKTAG1", new[] { "TFUKTRDA", "TFUKCCTY", "TFUKTAG1" })
    };
}
