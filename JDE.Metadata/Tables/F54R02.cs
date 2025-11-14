using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R02 - .
/// </summary>
public class F54R02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AD54RAN.
        /// </summary>
        public const string AD54RAN = "AD54RAN";

        /// <summary>
        /// AD54RPGM.
        /// </summary>
        public const string AD54RPGM = "AD54RPGM";

        /// <summary>
        /// AD54RVERS.
        /// </summary>
        public const string AD54RVERS = "AD54RVERS";

        /// <summary>
        /// AD54RDL01.
        /// </summary>
        public const string AD54RDL01 = "AD54RDL01";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADMKEY.
        /// </summary>
        public const string ADMKEY = "ADMKEY";

        /// <summary>
        /// ADURCD.
        /// </summary>
        public const string ADURCD = "ADURCD";

        /// <summary>
        /// ADURDT.
        /// </summary>
        public const string ADURDT = "ADURDT";

        /// <summary>
        /// ADURAT.
        /// </summary>
        public const string ADURAT = "ADURAT";

        /// <summary>
        /// ADURAB.
        /// </summary>
        public const string ADURAB = "ADURAB";

        /// <summary>
        /// ADURRF.
        /// </summary>
        public const string ADURRF = "ADURRF";

        /// <summary>
        /// ADENTJ.
        /// </summary>
        public const string ADENTJ = "ADENTJ";

        /// <summary>
        /// ADTORG.
        /// </summary>
        public const string ADTORG = "ADTORG";

        /// <summary>
        /// ADTENT.
        /// </summary>
        public const string ADTENT = "ADTENT";

        /// <summary>
        /// AD54TMNG.
        /// </summary>
        public const string AD54TMNG = "AD54TMNG";
    }

    /// <inheritdoc />
    public override string TableName => "F54R02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AD54RAN", "AD54RAN", JdeDataType.Numeric, null, true, true),
        new JdeField("AD54RPGM", "AD54RPGM", JdeDataType.String, 20),
        new JdeField("AD54RVERS", "AD54RVERS", JdeDataType.String, 20),
        new JdeField("AD54RDL01", "AD54RDL01", JdeDataType.String, 60),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADMKEY", "ADMKEY", JdeDataType.String, 30),
        new JdeField("ADURCD", "ADURCD", JdeDataType.String, 4),
        new JdeField("ADURDT", "ADURDT", JdeDataType.Numeric),
        new JdeField("ADURAT", "ADURAT", JdeDataType.Numeric),
        new JdeField("ADURAB", "ADURAB", JdeDataType.Numeric),
        new JdeField("ADURRF", "ADURRF", JdeDataType.String, 30),
        new JdeField("ADENTJ", "ADENTJ", JdeDataType.Numeric),
        new JdeField("ADTORG", "ADTORG", JdeDataType.String, 20),
        new JdeField("ADTENT", "ADTENT", JdeDataType.Numeric),
        new JdeField("AD54TMNG", "AD54TMNG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R02_0", "Primary Key on AD54RAN", new[] { "AD54RAN" }, isUnique: true, isPrimaryKey: true)
    };
}
