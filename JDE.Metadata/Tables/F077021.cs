using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F077021 - .
/// </summary>
public class F077021 : JdeTable
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
        /// Y$PDBA.
        /// </summary>
        public const string Y_PDBA = "Y$PDBA";

        /// <summary>
        /// Y$TAXX.
        /// </summary>
        public const string Y_TAXX = "Y$TAXX";

        /// <summary>
        /// Y$DISO.
        /// </summary>
        public const string Y_DISO = "Y$DISO";

        /// <summary>
        /// Y$PAYG.
        /// </summary>
        public const string Y_PAYG = "Y$PAYG";

        /// <summary>
        /// Y$PAYN.
        /// </summary>
        public const string Y_PAYN = "Y$PAYN";

        /// <summary>
        /// Y$NP.
        /// </summary>
        public const string Y_NP = "Y$NP";

        /// <summary>
        /// Y$AD.
        /// </summary>
        public const string Y_AD = "Y$AD";

        /// <summary>
        /// Y$UFLG.
        /// </summary>
        public const string Y_UFLG = "Y$UFLG";
    }

    /// <inheritdoc />
    public override string TableName => "F077021";

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
        new JdeField("Y$PDBA", "Y$PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y$TAXX", "Y$TAXX", JdeDataType.String, 40),
        new JdeField("Y$DISO", "Y$DISO", JdeDataType.String, 2),
        new JdeField("Y$PAYG", "Y$PAYG", JdeDataType.String, 2),
        new JdeField("Y$PAYN", "Y$PAYN", JdeDataType.String, 2),
        new JdeField("Y$NP", "Y$NP", JdeDataType.Numeric),
        new JdeField("Y$AD", "Y$AD", JdeDataType.Numeric),
        new JdeField("Y$UFLG", "Y$UFLG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F077021_0", "Primary Key on Y$DTEY, Y$CO, Y$THTY, Y$EKEY, Y$AN8, Y$PDBA", new[] { "Y$DTEY", "Y$CO", "Y$THTY", "Y$EKEY", "Y$AN8", "Y$PDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
