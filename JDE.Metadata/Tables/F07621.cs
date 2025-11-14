using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07621 - .
/// </summary>
public class F07621 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// L1AN8.
        /// </summary>
        public const string L1AN8 = "L1AN8";

        /// <summary>
        /// L1RKID.
        /// </summary>
        public const string L1RKID = "L1RKID";

        /// <summary>
        /// L1LVST.
        /// </summary>
        public const string L1LVST = "L1LVST";

        /// <summary>
        /// L1LREL.
        /// </summary>
        public const string L1LREL = "L1LREL";

        /// <summary>
        /// L1ALPH.
        /// </summary>
        public const string L1ALPH = "L1ALPH";

        /// <summary>
        /// L1MEDC.
        /// </summary>
        public const string L1MEDC = "L1MEDC";

        /// <summary>
        /// L1LVBD.
        /// </summary>
        public const string L1LVBD = "L1LVBD";

        /// <summary>
        /// L1LVED.
        /// </summary>
        public const string L1LVED = "L1LVED";

        /// <summary>
        /// L1LVRD.
        /// </summary>
        public const string L1LVRD = "L1LVRD";

        /// <summary>
        /// L1NMDR.
        /// </summary>
        public const string L1NMDR = "L1NMDR";

        /// <summary>
        /// L1LDUR.
        /// </summary>
        public const string L1LDUR = "L1LDUR";

        /// <summary>
        /// L1DSIJ.
        /// </summary>
        public const string L1DSIJ = "L1DSIJ";

        /// <summary>
        /// L1MCRQ.
        /// </summary>
        public const string L1MCRQ = "L1MCRQ";

        /// <summary>
        /// L1MCRD.
        /// </summary>
        public const string L1MCRD = "L1MCRD";

        /// <summary>
        /// L1LVFC.
        /// </summary>
        public const string L1LVFC = "L1LVFC";

        /// <summary>
        /// L1KEEE.
        /// </summary>
        public const string L1KEEE = "L1KEEE";

        /// <summary>
        /// L1KEDT.
        /// </summary>
        public const string L1KEDT = "L1KEDT";

        /// <summary>
        /// L1KEJR.
        /// </summary>
        public const string L1KEJR = "L1KEJR";

        /// <summary>
        /// L1KEJD.
        /// </summary>
        public const string L1KEJD = "L1KEJD";

        /// <summary>
        /// L1KEJE.
        /// </summary>
        public const string L1KEJE = "L1KEJE";

        /// <summary>
        /// L1USER.
        /// </summary>
        public const string L1USER = "L1USER";

        /// <summary>
        /// L1PID.
        /// </summary>
        public const string L1PID = "L1PID";

        /// <summary>
        /// L1JOBN.
        /// </summary>
        public const string L1JOBN = "L1JOBN";

        /// <summary>
        /// L1UPMJ.
        /// </summary>
        public const string L1UPMJ = "L1UPMJ";

        /// <summary>
        /// L1UPMT.
        /// </summary>
        public const string L1UPMT = "L1UPMT";

        /// <summary>
        /// L1SAN8.
        /// </summary>
        public const string L1SAN8 = "L1SAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F07621";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("L1AN8", "L1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("L1RKID", "L1RKID", JdeDataType.Numeric, null, true, true),
        new JdeField("L1LVST", "L1LVST", JdeDataType.String, 2, true, true),
        new JdeField("L1LREL", "L1LREL", JdeDataType.String, 2),
        new JdeField("L1ALPH", "L1ALPH", JdeDataType.String, 80),
        new JdeField("L1MEDC", "L1MEDC", JdeDataType.String, 80),
        new JdeField("L1LVBD", "L1LVBD", JdeDataType.Numeric),
        new JdeField("L1LVED", "L1LVED", JdeDataType.Numeric),
        new JdeField("L1LVRD", "L1LVRD", JdeDataType.Numeric),
        new JdeField("L1NMDR", "L1NMDR", JdeDataType.String, 80),
        new JdeField("L1LDUR", "L1LDUR", JdeDataType.Numeric),
        new JdeField("L1DSIJ", "L1DSIJ", JdeDataType.String, 80),
        new JdeField("L1MCRQ", "L1MCRQ", JdeDataType.String, 2),
        new JdeField("L1MCRD", "L1MCRD", JdeDataType.Numeric),
        new JdeField("L1LVFC", "L1LVFC", JdeDataType.String, 2),
        new JdeField("L1KEEE", "L1KEEE", JdeDataType.String, 2),
        new JdeField("L1KEDT", "L1KEDT", JdeDataType.Numeric),
        new JdeField("L1KEJR", "L1KEJR", JdeDataType.String, 2),
        new JdeField("L1KEJD", "L1KEJD", JdeDataType.Numeric),
        new JdeField("L1KEJE", "L1KEJE", JdeDataType.Numeric),
        new JdeField("L1USER", "L1USER", JdeDataType.String, 20),
        new JdeField("L1PID", "L1PID", JdeDataType.String, 20),
        new JdeField("L1JOBN", "L1JOBN", JdeDataType.String, 20),
        new JdeField("L1UPMJ", "L1UPMJ", JdeDataType.Numeric),
        new JdeField("L1UPMT", "L1UPMT", JdeDataType.Numeric),
        new JdeField("L1SAN8", "L1SAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07621_0", "Primary Key on L1AN8, L1RKID, L1LVST", new[] { "L1AN8", "L1RKID", "L1LVST" }, isUnique: true, isPrimaryKey: true)
    };
}
