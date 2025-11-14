using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI008 - .
/// </summary>
public class F09UI008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GMCTID.
        /// </summary>
        public const string GMCTID = "GMCTID";

        /// <summary>
        /// GMJOBS.
        /// </summary>
        public const string GMJOBS = "GMJOBS";

        /// <summary>
        /// GMMCU.
        /// </summary>
        public const string GMMCU = "GMMCU";

        /// <summary>
        /// GMTMCU.
        /// </summary>
        public const string GMTMCU = "GMTMCU";

        /// <summary>
        /// GMOBJ.
        /// </summary>
        public const string GMOBJ = "GMOBJ";

        /// <summary>
        /// GMOBJ1.
        /// </summary>
        public const string GMOBJ1 = "GMOBJ1";

        /// <summary>
        /// GMSUB.
        /// </summary>
        public const string GMSUB = "GMSUB";

        /// <summary>
        /// GMSUB1.
        /// </summary>
        public const string GMSUB1 = "GMSUB1";

        /// <summary>
        /// GMCO.
        /// </summary>
        public const string GMCO = "GMCO";

        /// <summary>
        /// GMOBJ2.
        /// </summary>
        public const string GMOBJ2 = "GMOBJ2";

        /// <summary>
        /// GMOBJ3.
        /// </summary>
        public const string GMOBJ3 = "GMOBJ3";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GMCTID", "GMCTID", JdeDataType.String, 30, true, true),
        new JdeField("GMJOBS", "GMJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GMMCU", "GMMCU", JdeDataType.String, 24, true, true),
        new JdeField("GMTMCU", "GMTMCU", JdeDataType.String, 24),
        new JdeField("GMOBJ", "GMOBJ", JdeDataType.String, 12, true, true),
        new JdeField("GMOBJ1", "GMOBJ1", JdeDataType.String, 12),
        new JdeField("GMSUB", "GMSUB", JdeDataType.String, 16, true, true),
        new JdeField("GMSUB1", "GMSUB1", JdeDataType.String, 16),
        new JdeField("GMCO", "GMCO", JdeDataType.String, 10),
        new JdeField("GMOBJ2", "GMOBJ2", JdeDataType.String, 12),
        new JdeField("GMOBJ3", "GMOBJ3", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI008_0", "Primary Key on GMCTID, GMJOBS, GMMCU, GMOBJ, GMSUB", new[] { "GMCTID", "GMJOBS", "GMMCU", "GMOBJ", "GMSUB" }, isUnique: true, isPrimaryKey: true)
    };
}
