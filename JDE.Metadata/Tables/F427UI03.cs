using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F427UI03 - .
/// </summary>
public class F427UI03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSJOBS.
        /// </summary>
        public const string RSJOBS = "RSJOBS";

        /// <summary>
        /// RSSHPN.
        /// </summary>
        public const string RSSHPN = "RSSHPN";

        /// <summary>
        /// RSRSFC01.
        /// </summary>
        public const string RSRSFC01 = "RSRSFC01";

        /// <summary>
        /// RSRSFC02.
        /// </summary>
        public const string RSRSFC02 = "RSRSFC02";

        /// <summary>
        /// RSRSFS01.
        /// </summary>
        public const string RSRSFS01 = "RSRSFS01";

        /// <summary>
        /// RSRSFS02.
        /// </summary>
        public const string RSRSFS02 = "RSRSFS02";

        /// <summary>
        /// RSRSFD01.
        /// </summary>
        public const string RSRSFD01 = "RSRSFD01";

        /// <summary>
        /// RSRSFD02.
        /// </summary>
        public const string RSRSFD02 = "RSRSFD02";

        /// <summary>
        /// RSRSFN01.
        /// </summary>
        public const string RSRSFN01 = "RSRSFN01";

        /// <summary>
        /// RSRSFN02.
        /// </summary>
        public const string RSRSFN02 = "RSRSFN02";

        /// <summary>
        /// RSRSFA01.
        /// </summary>
        public const string RSRSFA01 = "RSRSFA01";

        /// <summary>
        /// RSRSFA02.
        /// </summary>
        public const string RSRSFA02 = "RSRSFA02";

        /// <summary>
        /// RSURCD.
        /// </summary>
        public const string RSURCD = "RSURCD";

        /// <summary>
        /// RSURDT.
        /// </summary>
        public const string RSURDT = "RSURDT";

        /// <summary>
        /// RSURRF.
        /// </summary>
        public const string RSURRF = "RSURRF";

        /// <summary>
        /// RSURAT.
        /// </summary>
        public const string RSURAT = "RSURAT";

        /// <summary>
        /// RSURAB.
        /// </summary>
        public const string RSURAB = "RSURAB";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSJOBN.
        /// </summary>
        public const string RSJOBN = "RSJOBN";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSTDAY.
        /// </summary>
        public const string RSTDAY = "RSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F427UI03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSJOBS", "RSJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("RSSHPN", "RSSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("RSRSFC01", "RSRSFC01", JdeDataType.String, 2),
        new JdeField("RSRSFC02", "RSRSFC02", JdeDataType.String, 2),
        new JdeField("RSRSFS01", "RSRSFS01", JdeDataType.String, 4),
        new JdeField("RSRSFS02", "RSRSFS02", JdeDataType.String, 4),
        new JdeField("RSRSFD01", "RSRSFD01", JdeDataType.Numeric),
        new JdeField("RSRSFD02", "RSRSFD02", JdeDataType.Numeric),
        new JdeField("RSRSFN01", "RSRSFN01", JdeDataType.Numeric),
        new JdeField("RSRSFN02", "RSRSFN02", JdeDataType.Numeric),
        new JdeField("RSRSFA01", "RSRSFA01", JdeDataType.Numeric),
        new JdeField("RSRSFA02", "RSRSFA02", JdeDataType.Numeric),
        new JdeField("RSURCD", "RSURCD", JdeDataType.String, 4),
        new JdeField("RSURDT", "RSURDT", JdeDataType.Numeric),
        new JdeField("RSURRF", "RSURRF", JdeDataType.String, 30),
        new JdeField("RSURAT", "RSURAT", JdeDataType.Numeric),
        new JdeField("RSURAB", "RSURAB", JdeDataType.Numeric),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSJOBN", "RSJOBN", JdeDataType.String, 20),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSTDAY", "RSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F427UI03_0", "Primary Key on RSJOBS, RSSHPN", new[] { "RSJOBS", "RSSHPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F427UI03_2", "Index on RSSHPN", new[] { "RSSHPN" })
    };
}
