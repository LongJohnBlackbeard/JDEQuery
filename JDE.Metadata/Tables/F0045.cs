using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0045 - .
/// </summary>
public class F0045 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ERUKID.
        /// </summary>
        public const string ERUKID = "ERUKID";

        /// <summary>
        /// ERBSSVPCK.
        /// </summary>
        public const string ERBSSVPCK = "ERBSSVPCK";

        /// <summary>
        /// ERSBFMDNM.
        /// </summary>
        public const string ERSBFMDNM = "ERSBFMDNM";

        /// <summary>
        /// ERGENKEY.
        /// </summary>
        public const string ERGENKEY = "ERGENKEY";

        /// <summary>
        /// ERCDAC.
        /// </summary>
        public const string ERCDAC = "ERCDAC";

        /// <summary>
        /// ERBSSVXML.
        /// </summary>
        public const string ERBSSVXML = "ERBSSVXML";

        /// <summary>
        /// ERBSSVTRTY.
        /// </summary>
        public const string ERBSSVTRTY = "ERBSSVTRTY";

        /// <summary>
        /// ERBSSVERR.
        /// </summary>
        public const string ERBSSVERR = "ERBSSVERR";

        /// <summary>
        /// ERTRUNC.
        /// </summary>
        public const string ERTRUNC = "ERTRUNC";

        /// <summary>
        /// ERREPSTS.
        /// </summary>
        public const string ERREPSTS = "ERREPSTS";

        /// <summary>
        /// ERREPNUM.
        /// </summary>
        public const string ERREPNUM = "ERREPNUM";

        /// <summary>
        /// ERCFUNCD.
        /// </summary>
        public const string ERCFUNCD = "ERCFUNCD";

        /// <summary>
        /// ERURCD.
        /// </summary>
        public const string ERURCD = "ERURCD";

        /// <summary>
        /// ERURAB.
        /// </summary>
        public const string ERURAB = "ERURAB";

        /// <summary>
        /// ERURRF.
        /// </summary>
        public const string ERURRF = "ERURRF";

        /// <summary>
        /// ERURDT.
        /// </summary>
        public const string ERURDT = "ERURDT";

        /// <summary>
        /// ERURAT.
        /// </summary>
        public const string ERURAT = "ERURAT";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERMKEY.
        /// </summary>
        public const string ERMKEY = "ERMKEY";

        /// <summary>
        /// ERUUPMJ.
        /// </summary>
        public const string ERUUPMJ = "ERUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F0045";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ERUKID", "ERUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ERBSSVPCK", "ERBSSVPCK", JdeDataType.String, 512),
        new JdeField("ERSBFMDNM", "ERSBFMDNM", JdeDataType.String, 240),
        new JdeField("ERGENKEY", "ERGENKEY", JdeDataType.String, 80),
        new JdeField("ERCDAC", "ERCDAC", JdeDataType.String, 2),
        new JdeField("ERBSSVXML", "ERBSSVXML", JdeDataType.String),
        new JdeField("ERBSSVTRTY", "ERBSSVTRTY", JdeDataType.String, 20),
        new JdeField("ERBSSVERR", "ERBSSVERR", JdeDataType.String, 3998),
        new JdeField("ERTRUNC", "ERTRUNC", JdeDataType.String, 2),
        new JdeField("ERREPSTS", "ERREPSTS", JdeDataType.String, 2),
        new JdeField("ERREPNUM", "ERREPNUM", JdeDataType.Numeric),
        new JdeField("ERCFUNCD", "ERCFUNCD", JdeDataType.String, 60),
        new JdeField("ERURCD", "ERURCD", JdeDataType.String, 4),
        new JdeField("ERURAB", "ERURAB", JdeDataType.Numeric),
        new JdeField("ERURRF", "ERURRF", JdeDataType.String, 30),
        new JdeField("ERURDT", "ERURDT", JdeDataType.Numeric),
        new JdeField("ERURAT", "ERURAT", JdeDataType.Numeric),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERMKEY", "ERMKEY", JdeDataType.String, 30),
        new JdeField("ERUUPMJ", "ERUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0045_0", "Primary Key on ERUKID", new[] { "ERUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0045_2", "Index on ERBSSVPCK, ERSBFMDNM, ERGENKEY, ERCDAC", new[] { "ERBSSVPCK", "ERSBFMDNM", "ERGENKEY", "ERCDAC" })
    };
}
