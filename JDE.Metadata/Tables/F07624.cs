using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07624 - .
/// </summary>
public class F07624 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// L4AN8.
        /// </summary>
        public const string L4AN8 = "L4AN8";

        /// <summary>
        /// L4RKID.
        /// </summary>
        public const string L4RKID = "L4RKID";

        /// <summary>
        /// L4LVST.
        /// </summary>
        public const string L4LVST = "L4LVST";

        /// <summary>
        /// L4LREL.
        /// </summary>
        public const string L4LREL = "L4LREL";

        /// <summary>
        /// L4ALPH.
        /// </summary>
        public const string L4ALPH = "L4ALPH";

        /// <summary>
        /// L4MEDC.
        /// </summary>
        public const string L4MEDC = "L4MEDC";

        /// <summary>
        /// L4LVBD.
        /// </summary>
        public const string L4LVBD = "L4LVBD";

        /// <summary>
        /// L4LVED.
        /// </summary>
        public const string L4LVED = "L4LVED";

        /// <summary>
        /// L4LVRD.
        /// </summary>
        public const string L4LVRD = "L4LVRD";

        /// <summary>
        /// L4NMDR.
        /// </summary>
        public const string L4NMDR = "L4NMDR";

        /// <summary>
        /// L4LDUR.
        /// </summary>
        public const string L4LDUR = "L4LDUR";

        /// <summary>
        /// L4DSIJ.
        /// </summary>
        public const string L4DSIJ = "L4DSIJ";

        /// <summary>
        /// L4MCRQ.
        /// </summary>
        public const string L4MCRQ = "L4MCRQ";

        /// <summary>
        /// L4MCRD.
        /// </summary>
        public const string L4MCRD = "L4MCRD";

        /// <summary>
        /// L4LVFC.
        /// </summary>
        public const string L4LVFC = "L4LVFC";

        /// <summary>
        /// L4KEEE.
        /// </summary>
        public const string L4KEEE = "L4KEEE";

        /// <summary>
        /// L4KEDT.
        /// </summary>
        public const string L4KEDT = "L4KEDT";

        /// <summary>
        /// L4KEJR.
        /// </summary>
        public const string L4KEJR = "L4KEJR";

        /// <summary>
        /// L4KEJD.
        /// </summary>
        public const string L4KEJD = "L4KEJD";

        /// <summary>
        /// L4KEJE.
        /// </summary>
        public const string L4KEJE = "L4KEJE";

        /// <summary>
        /// L4USER.
        /// </summary>
        public const string L4USER = "L4USER";

        /// <summary>
        /// L4PID.
        /// </summary>
        public const string L4PID = "L4PID";

        /// <summary>
        /// L4JOBN.
        /// </summary>
        public const string L4JOBN = "L4JOBN";

        /// <summary>
        /// L4UPMJ.
        /// </summary>
        public const string L4UPMJ = "L4UPMJ";

        /// <summary>
        /// L4UPMT.
        /// </summary>
        public const string L4UPMT = "L4UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F07624";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("L4AN8", "L4AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("L4RKID", "L4RKID", JdeDataType.Numeric, null, true, true),
        new JdeField("L4LVST", "L4LVST", JdeDataType.String, 2),
        new JdeField("L4LREL", "L4LREL", JdeDataType.String, 2),
        new JdeField("L4ALPH", "L4ALPH", JdeDataType.String, 80),
        new JdeField("L4MEDC", "L4MEDC", JdeDataType.String, 80),
        new JdeField("L4LVBD", "L4LVBD", JdeDataType.Numeric),
        new JdeField("L4LVED", "L4LVED", JdeDataType.Numeric),
        new JdeField("L4LVRD", "L4LVRD", JdeDataType.Numeric),
        new JdeField("L4NMDR", "L4NMDR", JdeDataType.String, 80),
        new JdeField("L4LDUR", "L4LDUR", JdeDataType.Numeric),
        new JdeField("L4DSIJ", "L4DSIJ", JdeDataType.String, 80),
        new JdeField("L4MCRQ", "L4MCRQ", JdeDataType.String, 2),
        new JdeField("L4MCRD", "L4MCRD", JdeDataType.Numeric),
        new JdeField("L4LVFC", "L4LVFC", JdeDataType.String, 2),
        new JdeField("L4KEEE", "L4KEEE", JdeDataType.String, 2),
        new JdeField("L4KEDT", "L4KEDT", JdeDataType.Numeric),
        new JdeField("L4KEJR", "L4KEJR", JdeDataType.String, 2),
        new JdeField("L4KEJD", "L4KEJD", JdeDataType.Numeric),
        new JdeField("L4KEJE", "L4KEJE", JdeDataType.Numeric),
        new JdeField("L4USER", "L4USER", JdeDataType.String, 20),
        new JdeField("L4PID", "L4PID", JdeDataType.String, 20),
        new JdeField("L4JOBN", "L4JOBN", JdeDataType.String, 20),
        new JdeField("L4UPMJ", "L4UPMJ", JdeDataType.Numeric),
        new JdeField("L4UPMT", "L4UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07624_0", "Primary Key on L4AN8, L4RKID", new[] { "L4AN8", "L4RKID" }, isUnique: true, isPrimaryKey: true)
    };
}
