using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B421 - .
/// </summary>
public class F03B421 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THCO.
        /// </summary>
        public const string THCO = "THCO";

        /// <summary>
        /// THDCTOS.
        /// </summary>
        public const string THDCTOS = "THDCTOS";

        /// <summary>
        /// THLNTYS.
        /// </summary>
        public const string THLNTYS = "THLNTYS";

        /// <summary>
        /// THHMCUS.
        /// </summary>
        public const string THHMCUS = "THHMCUS";

        /// <summary>
        /// THSHTS.
        /// </summary>
        public const string THSHTS = "THSHTS";

        /// <summary>
        /// THSOTS.
        /// </summary>
        public const string THSOTS = "THSOTS";

        /// <summary>
        /// THDMCUS.
        /// </summary>
        public const string THDMCUS = "THDMCUS";

        /// <summary>
        /// THSHFCS.
        /// </summary>
        public const string THSHFCS = "THSHFCS";

        /// <summary>
        /// THSHTCS.
        /// </summary>
        public const string THSHTCS = "THSHTCS";

        /// <summary>
        /// THSOTCS.
        /// </summary>
        public const string THSOTCS = "THSOTCS";

        /// <summary>
        /// THSHCCS.
        /// </summary>
        public const string THSHCCS = "THSHCCS";

        /// <summary>
        /// THSOCCS.
        /// </summary>
        public const string THSOCCS = "THSOCCS";

        /// <summary>
        /// THFOBS.
        /// </summary>
        public const string THFOBS = "THFOBS";

        /// <summary>
        /// THCARNS.
        /// </summary>
        public const string THCARNS = "THCARNS";

        /// <summary>
        /// THMOTS.
        /// </summary>
        public const string THMOTS = "THMOTS";

        /// <summary>
        /// THSHCC.
        /// </summary>
        public const string THSHCC = "THSHCC";

        /// <summary>
        /// THSOTCC.
        /// </summary>
        public const string THSOTCC = "THSOTCC";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";
    }

    /// <inheritdoc />
    public override string TableName => "F03B421";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THCO", "THCO", JdeDataType.String, 10, true, true),
        new JdeField("THDCTOS", "THDCTOS", JdeDataType.Numeric),
        new JdeField("THLNTYS", "THLNTYS", JdeDataType.Numeric),
        new JdeField("THHMCUS", "THHMCUS", JdeDataType.Numeric),
        new JdeField("THSHTS", "THSHTS", JdeDataType.Numeric),
        new JdeField("THSOTS", "THSOTS", JdeDataType.Numeric),
        new JdeField("THDMCUS", "THDMCUS", JdeDataType.Numeric),
        new JdeField("THSHFCS", "THSHFCS", JdeDataType.Numeric),
        new JdeField("THSHTCS", "THSHTCS", JdeDataType.Numeric),
        new JdeField("THSOTCS", "THSOTCS", JdeDataType.Numeric),
        new JdeField("THSHCCS", "THSHCCS", JdeDataType.Numeric),
        new JdeField("THSOCCS", "THSOCCS", JdeDataType.Numeric),
        new JdeField("THFOBS", "THFOBS", JdeDataType.Numeric),
        new JdeField("THCARNS", "THCARNS", JdeDataType.Numeric),
        new JdeField("THMOTS", "THMOTS", JdeDataType.Numeric),
        new JdeField("THSHCC", "THSHCC", JdeDataType.Numeric),
        new JdeField("THSOTCC", "THSOTCC", JdeDataType.Numeric),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B421_0", "Primary Key on THCO", new[] { "THCO" }, isUnique: true, isPrimaryKey: true)
    };
}
