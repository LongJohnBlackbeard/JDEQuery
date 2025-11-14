using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R143 - .
/// </summary>
public class F40R143 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSDEID.
        /// </summary>
        public const string DSDEID = "DSDEID";

        /// <summary>
        /// DSPARTYTYP.
        /// </summary>
        public const string DSPARTYTYP = "DSPARTYTYP";

        /// <summary>
        /// DSPARTYNM.
        /// </summary>
        public const string DSPARTYNM = "DSPARTYNM";

        /// <summary>
        /// DSIDNUMTYP.
        /// </summary>
        public const string DSIDNUMTYP = "DSIDNUMTYP";

        /// <summary>
        /// DSPARTYID.
        /// </summary>
        public const string DSPARTYID = "DSPARTYID";

        /// <summary>
        /// DSPRNA1.
        /// </summary>
        public const string DSPRNA1 = "DSPRNA1";

        /// <summary>
        /// DSPRNA2.
        /// </summary>
        public const string DSPRNA2 = "DSPRNA2";

        /// <summary>
        /// DSDMDAD1.
        /// </summary>
        public const string DSDMDAD1 = "DSDMDAD1";

        /// <summary>
        /// DSDMDAD2.
        /// </summary>
        public const string DSDMDAD2 = "DSDMDAD2";

        /// <summary>
        /// DSCTY1.
        /// </summary>
        public const string DSCTY1 = "DSCTY1";

        /// <summary>
        /// DSCOUN.
        /// </summary>
        public const string DSCOUN = "DSCOUN";

        /// <summary>
        /// DSSTPROV.
        /// </summary>
        public const string DSSTPROV = "DSSTPROV";

        /// <summary>
        /// DSZIPCD.
        /// </summary>
        public const string DSZIPCD = "DSZIPCD";

        /// <summary>
        /// DSCTR.
        /// </summary>
        public const string DSCTR = "DSCTR";

        /// <summary>
        /// DSURCD.
        /// </summary>
        public const string DSURCD = "DSURCD";

        /// <summary>
        /// DSURDT.
        /// </summary>
        public const string DSURDT = "DSURDT";

        /// <summary>
        /// DSURAT.
        /// </summary>
        public const string DSURAT = "DSURAT";

        /// <summary>
        /// DSURAB.
        /// </summary>
        public const string DSURAB = "DSURAB";

        /// <summary>
        /// DSURRF.
        /// </summary>
        public const string DSURRF = "DSURRF";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSJOBN.
        /// </summary>
        public const string DSJOBN = "DSJOBN";

        /// <summary>
        /// DSUPMJ.
        /// </summary>
        public const string DSUPMJ = "DSUPMJ";

        /// <summary>
        /// DSTDAY.
        /// </summary>
        public const string DSTDAY = "DSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R143";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSDEID", "DSDEID", JdeDataType.Numeric, null, true, true),
        new JdeField("DSPARTYTYP", "DSPARTYTYP", JdeDataType.String, 6, true, true),
        new JdeField("DSPARTYNM", "DSPARTYNM", JdeDataType.String, 70),
        new JdeField("DSIDNUMTYP", "DSIDNUMTYP", JdeDataType.String, 4),
        new JdeField("DSPARTYID", "DSPARTYID", JdeDataType.String, 70),
        new JdeField("DSPRNA1", "DSPRNA1", JdeDataType.String, 70),
        new JdeField("DSPRNA2", "DSPRNA2", JdeDataType.String, 70),
        new JdeField("DSDMDAD1", "DSDMDAD1", JdeDataType.String, 70),
        new JdeField("DSDMDAD2", "DSDMDAD2", JdeDataType.String, 70),
        new JdeField("DSCTY1", "DSCTY1", JdeDataType.String, 50),
        new JdeField("DSCOUN", "DSCOUN", JdeDataType.String, 50),
        new JdeField("DSSTPROV", "DSSTPROV", JdeDataType.String, 70),
        new JdeField("DSZIPCD", "DSZIPCD", JdeDataType.String, 24),
        new JdeField("DSCTR", "DSCTR", JdeDataType.String, 6),
        new JdeField("DSURCD", "DSURCD", JdeDataType.String, 4),
        new JdeField("DSURDT", "DSURDT", JdeDataType.Numeric),
        new JdeField("DSURAT", "DSURAT", JdeDataType.Numeric),
        new JdeField("DSURAB", "DSURAB", JdeDataType.Numeric),
        new JdeField("DSURRF", "DSURRF", JdeDataType.String, 30),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSTDAY", "DSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R143_0", "Primary Key on DSDEID, DSPARTYTYP", new[] { "DSDEID", "DSPARTYTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
