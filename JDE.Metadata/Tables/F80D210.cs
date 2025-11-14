using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D210 - .
/// </summary>
public class F80D210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRPRDJ.
        /// </summary>
        public const string CRPRDJ = "CRPRDJ";

        /// <summary>
        /// CRMCU.
        /// </summary>
        public const string CRMCU = "CRMCU";

        /// <summary>
        /// CRAN8.
        /// </summary>
        public const string CRAN8 = "CRAN8";

        /// <summary>
        /// CRITM.
        /// </summary>
        public const string CRITM = "CRITM";

        /// <summary>
        /// CREYCT.
        /// </summary>
        public const string CREYCT = "CREYCT";

        /// <summary>
        /// CROTCT.
        /// </summary>
        public const string CROTCT = "CROTCT";

        /// <summary>
        /// CRLATECT.
        /// </summary>
        public const string CRLATECT = "CRLATECT";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRMKEY.
        /// </summary>
        public const string CRMKEY = "CRMKEY";

        /// <summary>
        /// CRUTIME.
        /// </summary>
        public const string CRUTIME = "CRUTIME";

        /// <summary>
        /// CRURCD.
        /// </summary>
        public const string CRURCD = "CRURCD";

        /// <summary>
        /// CRURDT.
        /// </summary>
        public const string CRURDT = "CRURDT";

        /// <summary>
        /// CRURAT.
        /// </summary>
        public const string CRURAT = "CRURAT";

        /// <summary>
        /// CRURAB.
        /// </summary>
        public const string CRURAB = "CRURAB";

        /// <summary>
        /// CRURRF.
        /// </summary>
        public const string CRURRF = "CRURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRPRDJ", "CRPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CRMCU", "CRMCU", JdeDataType.String, 24, true, true),
        new JdeField("CRAN8", "CRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CRITM", "CRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CREYCT", "CREYCT", JdeDataType.Numeric),
        new JdeField("CROTCT", "CROTCT", JdeDataType.Numeric),
        new JdeField("CRLATECT", "CRLATECT", JdeDataType.Numeric),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRMKEY", "CRMKEY", JdeDataType.String, 30),
        new JdeField("CRUTIME", "CRUTIME", JdeDataType.Date),
        new JdeField("CRURCD", "CRURCD", JdeDataType.String, 4),
        new JdeField("CRURDT", "CRURDT", JdeDataType.Numeric),
        new JdeField("CRURAT", "CRURAT", JdeDataType.Numeric),
        new JdeField("CRURAB", "CRURAB", JdeDataType.Numeric),
        new JdeField("CRURRF", "CRURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D210_0", "Primary Key on CRPRDJ, CRMCU, CRAN8, CRITM", new[] { "CRPRDJ", "CRMCU", "CRAN8", "CRITM" }, isUnique: true, isPrimaryKey: true)
    };
}
