using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F077011A - .
/// </summary>
public class F077011A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y$DTEY.
        /// </summary>
        public const string Y_DTEY = "Y$DTEY";

        /// <summary>
        /// Y$CO.
        /// </summary>
        public const string Y_CO = "Y$CO";

        /// <summary>
        /// Y$THTY.
        /// </summary>
        public const string Y_THTY = "Y$THTY";

        /// <summary>
        /// Y$EKEY.
        /// </summary>
        public const string Y_EKEY = "Y$EKEY";

        /// <summary>
        /// Y$AN8.
        /// </summary>
        public const string Y_AN8 = "Y$AN8";

        /// <summary>
        /// Y$SSN.
        /// </summary>
        public const string Y_SSN = "Y$SSN";

        /// <summary>
        /// Y$ALPH.
        /// </summary>
        public const string Y_ALPH = "Y$ALPH";

        /// <summary>
        /// Y$TARA.
        /// </summary>
        public const string Y_TARA = "Y$TARA";

        /// <summary>
        /// Y$PTAX.
        /// </summary>
        public const string Y_PTAX = "Y$PTAX";

        /// <summary>
        /// Y$TAXX.
        /// </summary>
        public const string Y_TAXX = "Y$TAXX";

        /// <summary>
        /// Y$SCDC.
        /// </summary>
        public const string Y_SCDC = "Y$SCDC";

        /// <summary>
        /// Y$TACC.
        /// </summary>
        public const string Y_TACC = "Y$TACC";

        /// <summary>
        /// Y$WAG.
        /// </summary>
        public const string Y_WAG = "Y$WAG";

        /// <summary>
        /// Y$UFLG.
        /// </summary>
        public const string Y_UFLG = "Y$UFLG";
    }

    /// <inheritdoc />
    public override string TableName => "F077011A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y$DTEY", "Y$DTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("Y$CO", "Y$CO", JdeDataType.String, 10, true, true),
        new JdeField("Y$THTY", "Y$THTY", JdeDataType.String, 2, true, true),
        new JdeField("Y$EKEY", "Y$EKEY", JdeDataType.String, 8, true, true),
        new JdeField("Y$AN8", "Y$AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y$SSN", "Y$SSN", JdeDataType.String, 40),
        new JdeField("Y$ALPH", "Y$ALPH", JdeDataType.String, 80),
        new JdeField("Y$TARA", "Y$TARA", JdeDataType.String, 20, true, true),
        new JdeField("Y$PTAX", "Y$PTAX", JdeDataType.String, 4, true, true),
        new JdeField("Y$TAXX", "Y$TAXX", JdeDataType.String, 40, true, true),
        new JdeField("Y$SCDC", "Y$SCDC", JdeDataType.Numeric, null, true, true),
        new JdeField("Y$TACC", "Y$TACC", JdeDataType.String, 4, true, true),
        new JdeField("Y$WAG", "Y$WAG", JdeDataType.Numeric),
        new JdeField("Y$UFLG", "Y$UFLG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F077011A_0", "Primary Key on Y$DTEY, Y$CO, Y$EKEY, Y$AN8, Y$PTAX, Y$TARA, Y$THTY, Y$TAXX, Y$SCDC, Y$TACC", new[] { "Y$DTEY", "Y$CO", "Y$EKEY", "Y$AN8", "Y$PTAX", "Y$TARA", "Y$THTY", "Y$TAXX", "Y$SCDC", "Y$TACC" }, isUnique: true, isPrimaryKey: true)
    };
}
