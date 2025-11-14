using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI01 - .
/// </summary>
public class F75IUI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TWUKID.
        /// </summary>
        public const string TWUKID = "TWUKID";

        /// <summary>
        /// TWI75ICC.
        /// </summary>
        public const string TWI75ICC = "TWI75ICC";

        /// <summary>
        /// TWAN8.
        /// </summary>
        public const string TWAN8 = "TWAN8";

        /// <summary>
        /// TWCO.
        /// </summary>
        public const string TWCO = "TWCO";

        /// <summary>
        /// TWMCU.
        /// </summary>
        public const string TWMCU = "TWMCU";

        /// <summary>
        /// TWI75TOT.
        /// </summary>
        public const string TWI75TOT = "TWI75TOT";

        /// <summary>
        /// TWI75SURC.
        /// </summary>
        public const string TWI75SURC = "TWI75SURC";

        /// <summary>
        /// TWI75CESS.
        /// </summary>
        public const string TWI75CESS = "TWI75CESS";

        /// <summary>
        /// TWI75APD.
        /// </summary>
        public const string TWI75APD = "TWI75APD";

        /// <summary>
        /// TWI75CHQN.
        /// </summary>
        public const string TWI75CHQN = "TWI75CHQN";

        /// <summary>
        /// TWI75BSR.
        /// </summary>
        public const string TWI75BSR = "TWI75BSR";

        /// <summary>
        /// TWI75PYD.
        /// </summary>
        public const string TWI75PYD = "TWI75PYD";

        /// <summary>
        /// TWI75CHNO.
        /// </summary>
        public const string TWI75CHNO = "TWI75CHNO";

        /// <summary>
        /// TWAREC.
        /// </summary>
        public const string TWAREC = "TWAREC";

        /// <summary>
        /// TWI75TTR.
        /// </summary>
        public const string TWI75TTR = "TWI75TTR";

        /// <summary>
        /// TWIVD.
        /// </summary>
        public const string TWIVD = "TWIVD";

        /// <summary>
        /// TWUPMJ.
        /// </summary>
        public const string TWUPMJ = "TWUPMJ";

        /// <summary>
        /// TWUPMT.
        /// </summary>
        public const string TWUPMT = "TWUPMT";

        /// <summary>
        /// TWUSER.
        /// </summary>
        public const string TWUSER = "TWUSER";

        /// <summary>
        /// TWPID.
        /// </summary>
        public const string TWPID = "TWPID";

        /// <summary>
        /// TWJOBN.
        /// </summary>
        public const string TWJOBN = "TWJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TWUKID", "TWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TWI75ICC", "TWI75ICC", JdeDataType.String, 2),
        new JdeField("TWAN8", "TWAN8", JdeDataType.Numeric),
        new JdeField("TWCO", "TWCO", JdeDataType.String, 10),
        new JdeField("TWMCU", "TWMCU", JdeDataType.String, 24),
        new JdeField("TWI75TOT", "TWI75TOT", JdeDataType.Numeric),
        new JdeField("TWI75SURC", "TWI75SURC", JdeDataType.Numeric),
        new JdeField("TWI75CESS", "TWI75CESS", JdeDataType.Numeric),
        new JdeField("TWI75APD", "TWI75APD", JdeDataType.Numeric),
        new JdeField("TWI75CHQN", "TWI75CHQN", JdeDataType.Numeric),
        new JdeField("TWI75BSR", "TWI75BSR", JdeDataType.Numeric),
        new JdeField("TWI75PYD", "TWI75PYD", JdeDataType.Numeric),
        new JdeField("TWI75CHNO", "TWI75CHNO", JdeDataType.String, 120),
        new JdeField("TWAREC", "TWAREC", JdeDataType.Numeric),
        new JdeField("TWI75TTR", "TWI75TTR", JdeDataType.Numeric),
        new JdeField("TWIVD", "TWIVD", JdeDataType.Numeric),
        new JdeField("TWUPMJ", "TWUPMJ", JdeDataType.Numeric),
        new JdeField("TWUPMT", "TWUPMT", JdeDataType.Numeric),
        new JdeField("TWUSER", "TWUSER", JdeDataType.String, 20),
        new JdeField("TWPID", "TWPID", JdeDataType.String, 20),
        new JdeField("TWJOBN", "TWJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI01_0", "Primary Key on TWUKID", new[] { "TWUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
