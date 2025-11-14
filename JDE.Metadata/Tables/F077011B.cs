using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F077011B - .
/// </summary>
public class F077011B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y3DTEY.
        /// </summary>
        public const string Y3DTEY = "Y3DTEY";

        /// <summary>
        /// Y3HMCO.
        /// </summary>
        public const string Y3HMCO = "Y3HMCO";

        /// <summary>
        /// Y3THTY.
        /// </summary>
        public const string Y3THTY = "Y3THTY";

        /// <summary>
        /// Y3EKEY.
        /// </summary>
        public const string Y3EKEY = "Y3EKEY";

        /// <summary>
        /// Y3AN8.
        /// </summary>
        public const string Y3AN8 = "Y3AN8";

        /// <summary>
        /// Y3SSN.
        /// </summary>
        public const string Y3SSN = "Y3SSN";

        /// <summary>
        /// Y3ALPH.
        /// </summary>
        public const string Y3ALPH = "Y3ALPH";

        /// <summary>
        /// Y3TARA.
        /// </summary>
        public const string Y3TARA = "Y3TARA";

        /// <summary>
        /// Y3PTAX.
        /// </summary>
        public const string Y3PTAX = "Y3PTAX";

        /// <summary>
        /// Y3TAXX.
        /// </summary>
        public const string Y3TAXX = "Y3TAXX";

        /// <summary>
        /// Y3SCDC.
        /// </summary>
        public const string Y3SCDC = "Y3SCDC";

        /// <summary>
        /// Y3INTEGER.
        /// </summary>
        public const string Y3INTEGER = "Y3INTEGER";

        /// <summary>
        /// Y3WAG.
        /// </summary>
        public const string Y3WAG = "Y3WAG";

        /// <summary>
        /// Y3UFLG.
        /// </summary>
        public const string Y3UFLG = "Y3UFLG";

        /// <summary>
        /// Y3TXOF.
        /// </summary>
        public const string Y3TXOF = "Y3TXOF";
    }

    /// <inheritdoc />
    public override string TableName => "F077011B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y3DTEY", "Y3DTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("Y3HMCO", "Y3HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y3THTY", "Y3THTY", JdeDataType.String, 2, true, true),
        new JdeField("Y3EKEY", "Y3EKEY", JdeDataType.String, 8, true, true),
        new JdeField("Y3AN8", "Y3AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y3SSN", "Y3SSN", JdeDataType.String, 40),
        new JdeField("Y3ALPH", "Y3ALPH", JdeDataType.String, 80),
        new JdeField("Y3TARA", "Y3TARA", JdeDataType.String, 20, true, true),
        new JdeField("Y3PTAX", "Y3PTAX", JdeDataType.String, 4, true, true),
        new JdeField("Y3TAXX", "Y3TAXX", JdeDataType.String, 40, true, true),
        new JdeField("Y3SCDC", "Y3SCDC", JdeDataType.Numeric, null, true, true),
        new JdeField("Y3INTEGER", "Y3INTEGER", JdeDataType.Numeric, null, true, true),
        new JdeField("Y3WAG", "Y3WAG", JdeDataType.Numeric),
        new JdeField("Y3UFLG", "Y3UFLG", JdeDataType.String, 2),
        new JdeField("Y3TXOF", "Y3TXOF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F077011B_0", "Primary Key on Y3DTEY, Y3HMCO, Y3THTY, Y3EKEY, Y3AN8, Y3TARA, Y3PTAX, Y3TAXX, Y3SCDC, Y3INTEGER", new[] { "Y3DTEY", "Y3HMCO", "Y3THTY", "Y3EKEY", "Y3AN8", "Y3TARA", "Y3PTAX", "Y3TAXX", "Y3SCDC", "Y3INTEGER" }, isUnique: true, isPrimaryKey: true)
    };
}
