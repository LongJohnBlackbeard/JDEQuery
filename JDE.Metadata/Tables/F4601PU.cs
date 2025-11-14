using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4601PU - .
/// </summary>
public class F4601PU : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THPTSK.
        /// </summary>
        public const string THPTSK = "THPTSK";

        /// <summary>
        /// THTYFL.
        /// </summary>
        public const string THTYFL = "THTYFL";

        /// <summary>
        /// THPSTB.
        /// </summary>
        public const string THPSTB = "THPSTB";

        /// <summary>
        /// THNTRP.
        /// </summary>
        public const string THNTRP = "THNTRP";

        /// <summary>
        /// THMCU.
        /// </summary>
        public const string THMCU = "THMCU";

        /// <summary>
        /// THANP.
        /// </summary>
        public const string THANP = "THANP";

        /// <summary>
        /// THLVAR.
        /// </summary>
        public const string THLVAR = "THLVAR";

        /// <summary>
        /// THDTCR.
        /// </summary>
        public const string THDTCR = "THDTCR";

        /// <summary>
        /// THTMCR.
        /// </summary>
        public const string THTMCR = "THTMCR";

        /// <summary>
        /// THDTCO.
        /// </summary>
        public const string THDTCO = "THDTCO";

        /// <summary>
        /// THTMCO.
        /// </summary>
        public const string THTMCO = "THTMCO";

        /// <summary>
        /// THTSPR.
        /// </summary>
        public const string THTSPR = "THTSPR";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THTDAY.
        /// </summary>
        public const string THTDAY = "THTDAY";

        /// <summary>
        /// THDTE.
        /// </summary>
        public const string THDTE = "THDTE";

        /// <summary>
        /// THTICU.
        /// </summary>
        public const string THTICU = "THTICU";

        /// <summary>
        /// THSCHUSER.
        /// </summary>
        public const string THSCHUSER = "THSCHUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F4601PU";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THPTSK", "THPTSK", JdeDataType.Numeric, null, true, true),
        new JdeField("THTYFL", "THTYFL", JdeDataType.String, 2),
        new JdeField("THPSTB", "THPSTB", JdeDataType.String, 6),
        new JdeField("THNTRP", "THNTRP", JdeDataType.Numeric),
        new JdeField("THMCU", "THMCU", JdeDataType.String, 24),
        new JdeField("THANP", "THANP", JdeDataType.Numeric),
        new JdeField("THLVAR", "THLVAR", JdeDataType.String, 4),
        new JdeField("THDTCR", "THDTCR", JdeDataType.Numeric),
        new JdeField("THTMCR", "THTMCR", JdeDataType.Numeric),
        new JdeField("THDTCO", "THDTCO", JdeDataType.Numeric),
        new JdeField("THTMCO", "THTMCO", JdeDataType.Numeric),
        new JdeField("THTSPR", "THTSPR", JdeDataType.Numeric),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THTDAY", "THTDAY", JdeDataType.Numeric),
        new JdeField("THDTE", "THDTE", JdeDataType.Numeric),
        new JdeField("THTICU", "THTICU", JdeDataType.Numeric),
        new JdeField("THSCHUSER", "THSCHUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4601PU_0", "Primary Key on THPTSK", new[] { "THPTSK" }, isUnique: true, isPrimaryKey: true)
    };
}
