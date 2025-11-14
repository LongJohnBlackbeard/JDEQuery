using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I801 - .
/// </summary>
public class F75I801 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPLVLA.
        /// </summary>
        public const string TPLVLA = "TPLVLA";

        /// <summary>
        /// TPI75TXRL.
        /// </summary>
        public const string TPI75TXRL = "TPI75TXRL";

        /// <summary>
        /// TPI75TXTY.
        /// </summary>
        public const string TPI75TXTY = "TPI75TXTY";

        /// <summary>
        /// TPI75TXRG.
        /// </summary>
        public const string TPI75TXRG = "TPI75TXRG";

        /// <summary>
        /// TPUSER.
        /// </summary>
        public const string TPUSER = "TPUSER";

        /// <summary>
        /// TPPID.
        /// </summary>
        public const string TPPID = "TPPID";

        /// <summary>
        /// TPUPMJ.
        /// </summary>
        public const string TPUPMJ = "TPUPMJ";

        /// <summary>
        /// TPUPMT.
        /// </summary>
        public const string TPUPMT = "TPUPMT";

        /// <summary>
        /// TPJOBN.
        /// </summary>
        public const string TPJOBN = "TPJOBN";

        /// <summary>
        /// TPYFUTDT1.
        /// </summary>
        public const string TPYFUTDT1 = "TPYFUTDT1";

        /// <summary>
        /// TPFUT6.
        /// </summary>
        public const string TPFUT6 = "TPFUT6";

        /// <summary>
        /// TPYT04.
        /// </summary>
        public const string TPYT04 = "TPYT04";

        /// <summary>
        /// TPYFLAG.
        /// </summary>
        public const string TPYFLAG = "TPYFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I801";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPLVLA", "TPLVLA", JdeDataType.String, 6, true, true),
        new JdeField("TPI75TXRL", "TPI75TXRL", JdeDataType.String, 12),
        new JdeField("TPI75TXTY", "TPI75TXTY", JdeDataType.String, 10),
        new JdeField("TPI75TXRG", "TPI75TXRG", JdeDataType.String, 10),
        new JdeField("TPUSER", "TPUSER", JdeDataType.String, 20),
        new JdeField("TPPID", "TPPID", JdeDataType.String, 20),
        new JdeField("TPUPMJ", "TPUPMJ", JdeDataType.Numeric),
        new JdeField("TPUPMT", "TPUPMT", JdeDataType.Numeric),
        new JdeField("TPJOBN", "TPJOBN", JdeDataType.String, 20),
        new JdeField("TPYFUTDT1", "TPYFUTDT1", JdeDataType.Numeric),
        new JdeField("TPFUT6", "TPFUT6", JdeDataType.String, 60),
        new JdeField("TPYT04", "TPYT04", JdeDataType.String, 2),
        new JdeField("TPYFLAG", "TPYFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I801_0", "Primary Key on TPLVLA", new[] { "TPLVLA" }, isUnique: true, isPrimaryKey: true)
    };
}
