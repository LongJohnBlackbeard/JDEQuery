using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R14 - .
/// </summary>
public class F40R14 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DAUKID.
        /// </summary>
        public const string DAUKID = "DAUKID";

        /// <summary>
        /// DADEID.
        /// </summary>
        public const string DADEID = "DADEID";

        /// <summary>
        /// DAPARTYTYP.
        /// </summary>
        public const string DAPARTYTYP = "DAPARTYTYP";

        /// <summary>
        /// DAPARTYNM.
        /// </summary>
        public const string DAPARTYNM = "DAPARTYNM";

        /// <summary>
        /// DAIDNUMTYP.
        /// </summary>
        public const string DAIDNUMTYP = "DAIDNUMTYP";

        /// <summary>
        /// DAPARTYID.
        /// </summary>
        public const string DAPARTYID = "DAPARTYID";

        /// <summary>
        /// DAPRNA1.
        /// </summary>
        public const string DAPRNA1 = "DAPRNA1";

        /// <summary>
        /// DAPRNA2.
        /// </summary>
        public const string DAPRNA2 = "DAPRNA2";

        /// <summary>
        /// DADMDAD1.
        /// </summary>
        public const string DADMDAD1 = "DADMDAD1";

        /// <summary>
        /// DADMDAD2.
        /// </summary>
        public const string DADMDAD2 = "DADMDAD2";

        /// <summary>
        /// DACTY1.
        /// </summary>
        public const string DACTY1 = "DACTY1";

        /// <summary>
        /// DACOUN.
        /// </summary>
        public const string DACOUN = "DACOUN";

        /// <summary>
        /// DASTPROV.
        /// </summary>
        public const string DASTPROV = "DASTPROV";

        /// <summary>
        /// DAZIPCD.
        /// </summary>
        public const string DAZIPCD = "DAZIPCD";

        /// <summary>
        /// DACTR.
        /// </summary>
        public const string DACTR = "DACTR";

        /// <summary>
        /// DAURCD.
        /// </summary>
        public const string DAURCD = "DAURCD";

        /// <summary>
        /// DAURDT.
        /// </summary>
        public const string DAURDT = "DAURDT";

        /// <summary>
        /// DAURAT.
        /// </summary>
        public const string DAURAT = "DAURAT";

        /// <summary>
        /// DAURAB.
        /// </summary>
        public const string DAURAB = "DAURAB";

        /// <summary>
        /// DAURRF.
        /// </summary>
        public const string DAURRF = "DAURRF";

        /// <summary>
        /// DAUSER.
        /// </summary>
        public const string DAUSER = "DAUSER";

        /// <summary>
        /// DAPID.
        /// </summary>
        public const string DAPID = "DAPID";

        /// <summary>
        /// DAJOBN.
        /// </summary>
        public const string DAJOBN = "DAJOBN";

        /// <summary>
        /// DAUPMJ.
        /// </summary>
        public const string DAUPMJ = "DAUPMJ";

        /// <summary>
        /// DATDAY.
        /// </summary>
        public const string DATDAY = "DATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R14";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DAUKID", "DAUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DADEID", "DADEID", JdeDataType.Numeric, null, true, true),
        new JdeField("DAPARTYTYP", "DAPARTYTYP", JdeDataType.String, 6, true, true),
        new JdeField("DAPARTYNM", "DAPARTYNM", JdeDataType.String, 70),
        new JdeField("DAIDNUMTYP", "DAIDNUMTYP", JdeDataType.String, 4),
        new JdeField("DAPARTYID", "DAPARTYID", JdeDataType.String, 70),
        new JdeField("DAPRNA1", "DAPRNA1", JdeDataType.String, 70),
        new JdeField("DAPRNA2", "DAPRNA2", JdeDataType.String, 70),
        new JdeField("DADMDAD1", "DADMDAD1", JdeDataType.String, 70),
        new JdeField("DADMDAD2", "DADMDAD2", JdeDataType.String, 70),
        new JdeField("DACTY1", "DACTY1", JdeDataType.String, 50),
        new JdeField("DACOUN", "DACOUN", JdeDataType.String, 50),
        new JdeField("DASTPROV", "DASTPROV", JdeDataType.String, 70),
        new JdeField("DAZIPCD", "DAZIPCD", JdeDataType.String, 24),
        new JdeField("DACTR", "DACTR", JdeDataType.String, 6),
        new JdeField("DAURCD", "DAURCD", JdeDataType.String, 4),
        new JdeField("DAURDT", "DAURDT", JdeDataType.Numeric),
        new JdeField("DAURAT", "DAURAT", JdeDataType.Numeric),
        new JdeField("DAURAB", "DAURAB", JdeDataType.Numeric),
        new JdeField("DAURRF", "DAURRF", JdeDataType.String, 30),
        new JdeField("DAUSER", "DAUSER", JdeDataType.String, 20),
        new JdeField("DAPID", "DAPID", JdeDataType.String, 20),
        new JdeField("DAJOBN", "DAJOBN", JdeDataType.String, 20),
        new JdeField("DAUPMJ", "DAUPMJ", JdeDataType.Numeric),
        new JdeField("DATDAY", "DATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R14_0", "Primary Key on DAUKID, DADEID, DAPARTYTYP", new[] { "DAUKID", "DADEID", "DAPARTYTYP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40R14_2", "Index on DADEID, DAPARTYTYP", new[] { "DADEID", "DAPARTYTYP" })
    };
}
