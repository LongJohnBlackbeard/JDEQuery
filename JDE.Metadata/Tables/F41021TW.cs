using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41021TW - .
/// </summary>
public class F41021TW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TWJOBS.
        /// </summary>
        public const string TWJOBS = "TWJOBS";

        /// <summary>
        /// TWCTID.
        /// </summary>
        public const string TWCTID = "TWCTID";

        /// <summary>
        /// TWUKID.
        /// </summary>
        public const string TWUKID = "TWUKID";

        /// <summary>
        /// TWPIDP.
        /// </summary>
        public const string TWPIDP = "TWPIDP";

        /// <summary>
        /// TWITM.
        /// </summary>
        public const string TWITM = "TWITM";

        /// <summary>
        /// TWMCU.
        /// </summary>
        public const string TWMCU = "TWMCU";

        /// <summary>
        /// TWLOCN.
        /// </summary>
        public const string TWLOCN = "TWLOCN";

        /// <summary>
        /// TWLOTN.
        /// </summary>
        public const string TWLOTN = "TWLOTN";

        /// <summary>
        /// TWPNS.
        /// </summary>
        public const string TWPNS = "TWPNS";

        /// <summary>
        /// TWPMPN.
        /// </summary>
        public const string TWPMPN = "TWPMPN";

        /// <summary>
        /// TWPQOH.
        /// </summary>
        public const string TWPQOH = "TWPQOH";

        /// <summary>
        /// TWSQOH.
        /// </summary>
        public const string TWSQOH = "TWSQOH";

        /// <summary>
        /// TWJOBN.
        /// </summary>
        public const string TWJOBN = "TWJOBN";

        /// <summary>
        /// TWPID.
        /// </summary>
        public const string TWPID = "TWPID";

        /// <summary>
        /// TWUPMJ.
        /// </summary>
        public const string TWUPMJ = "TWUPMJ";

        /// <summary>
        /// TWUSER.
        /// </summary>
        public const string TWUSER = "TWUSER";

        /// <summary>
        /// TWTDAY.
        /// </summary>
        public const string TWTDAY = "TWTDAY";

        /// <summary>
        /// TWURDT.
        /// </summary>
        public const string TWURDT = "TWURDT";

        /// <summary>
        /// TWURCD.
        /// </summary>
        public const string TWURCD = "TWURCD";

        /// <summary>
        /// TWURAT.
        /// </summary>
        public const string TWURAT = "TWURAT";

        /// <summary>
        /// TWURRF.
        /// </summary>
        public const string TWURRF = "TWURRF";

        /// <summary>
        /// TWURAB.
        /// </summary>
        public const string TWURAB = "TWURAB";

        /// <summary>
        /// TWFFU3.
        /// </summary>
        public const string TWFFU3 = "TWFFU3";

        /// <summary>
        /// TWFFU4.
        /// </summary>
        public const string TWFFU4 = "TWFFU4";

        /// <summary>
        /// TWTFUDJ.
        /// </summary>
        public const string TWTFUDJ = "TWTFUDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F41021TW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TWJOBS", "TWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TWCTID", "TWCTID", JdeDataType.String, 30, true, true),
        new JdeField("TWUKID", "TWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TWPIDP", "TWPIDP", JdeDataType.String, 20, true, true),
        new JdeField("TWITM", "TWITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TWMCU", "TWMCU", JdeDataType.String, 24, true, true),
        new JdeField("TWLOCN", "TWLOCN", JdeDataType.String, 40, true, true),
        new JdeField("TWLOTN", "TWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("TWPNS", "TWPNS", JdeDataType.Numeric, null, true, true),
        new JdeField("TWPMPN", "TWPMPN", JdeDataType.String, 60),
        new JdeField("TWPQOH", "TWPQOH", JdeDataType.Numeric),
        new JdeField("TWSQOH", "TWSQOH", JdeDataType.Numeric),
        new JdeField("TWJOBN", "TWJOBN", JdeDataType.String, 20),
        new JdeField("TWPID", "TWPID", JdeDataType.String, 20),
        new JdeField("TWUPMJ", "TWUPMJ", JdeDataType.Numeric),
        new JdeField("TWUSER", "TWUSER", JdeDataType.String, 20),
        new JdeField("TWTDAY", "TWTDAY", JdeDataType.Numeric),
        new JdeField("TWURDT", "TWURDT", JdeDataType.Numeric),
        new JdeField("TWURCD", "TWURCD", JdeDataType.String, 4),
        new JdeField("TWURAT", "TWURAT", JdeDataType.Numeric),
        new JdeField("TWURRF", "TWURRF", JdeDataType.String, 30),
        new JdeField("TWURAB", "TWURAB", JdeDataType.Numeric),
        new JdeField("TWFFU3", "TWFFU3", JdeDataType.String, 20),
        new JdeField("TWFFU4", "TWFFU4", JdeDataType.Numeric),
        new JdeField("TWTFUDJ", "TWTFUDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41021TW_0", "Primary Key on TWJOBS, TWCTID, TWUKID, TWPIDP, TWITM, TWMCU, TWLOCN, TWLOTN, TWPNS", new[] { "TWJOBS", "TWCTID", "TWUKID", "TWPIDP", "TWITM", "TWMCU", "TWLOCN", "TWLOTN", "TWPNS" }, isUnique: true, isPrimaryKey: true)
    };
}
