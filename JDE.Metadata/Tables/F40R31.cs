using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R31 - .
/// </summary>
public class F40R31 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADMCU.
        /// </summary>
        public const string ADMCU = "ADMCU";

        /// <summary>
        /// ADAN8.
        /// </summary>
        public const string ADAN8 = "ADAN8";

        /// <summary>
        /// ADSHAN.
        /// </summary>
        public const string ADSHAN = "ADSHAN";

        /// <summary>
        /// ADTBLNME.
        /// </summary>
        public const string ADTBLNME = "ADTBLNME";

        /// <summary>
        /// ADCOLNME.
        /// </summary>
        public const string ADCOLNME = "ADCOLNME";

        /// <summary>
        /// ADSDB.
        /// </summary>
        public const string ADSDB = "ADSDB";

        /// <summary>
        /// ADTYDT.
        /// </summary>
        public const string ADTYDT = "ADTYDT";

        /// <summary>
        /// ADFUT1.
        /// </summary>
        public const string ADFUT1 = "ADFUT1";

        /// <summary>
        /// ADFUT2.
        /// </summary>
        public const string ADFUT2 = "ADFUT2";

        /// <summary>
        /// ADFUT3.
        /// </summary>
        public const string ADFUT3 = "ADFUT3";

        /// <summary>
        /// ADFUT4.
        /// </summary>
        public const string ADFUT4 = "ADFUT4";

        /// <summary>
        /// ADFUT5.
        /// </summary>
        public const string ADFUT5 = "ADFUT5";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADTDAY.
        /// </summary>
        public const string ADTDAY = "ADTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R31";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADMCU", "ADMCU", JdeDataType.String, 24, true, true),
        new JdeField("ADAN8", "ADAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ADSHAN", "ADSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("ADTBLNME", "ADTBLNME", JdeDataType.String, 20, true, true),
        new JdeField("ADCOLNME", "ADCOLNME", JdeDataType.String, 20, true, true),
        new JdeField("ADSDB", "ADSDB", JdeDataType.String, 8, true, true),
        new JdeField("ADTYDT", "ADTYDT", JdeDataType.String, 4, true, true),
        new JdeField("ADFUT1", "ADFUT1", JdeDataType.Numeric),
        new JdeField("ADFUT2", "ADFUT2", JdeDataType.Numeric),
        new JdeField("ADFUT3", "ADFUT3", JdeDataType.String, 60),
        new JdeField("ADFUT4", "ADFUT4", JdeDataType.String, 50),
        new JdeField("ADFUT5", "ADFUT5", JdeDataType.String, 50),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADTDAY", "ADTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R31_0", "Primary Key on ADAN8, ADSHAN, ADMCU, ADTBLNME, ADCOLNME, ADSDB, ADTYDT", new[] { "ADAN8", "ADSHAN", "ADMCU", "ADTBLNME", "ADCOLNME", "ADSDB", "ADTYDT" }, isUnique: true, isPrimaryKey: true)
    };
}
