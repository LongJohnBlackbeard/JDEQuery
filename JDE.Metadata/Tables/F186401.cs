using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186401 - .
/// </summary>
public class F186401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OSLRSORSID.
        /// </summary>
        public const string OSLRSORSID = "OSLRSORSID";

        /// <summary>
        /// OSLRSORSN.
        /// </summary>
        public const string OSLRSORSN = "OSLRSORSN";

        /// <summary>
        /// OSLRSEGID.
        /// </summary>
        public const string OSLRSEGID = "OSLRSEGID";

        /// <summary>
        /// OSLRSTEMV.
        /// </summary>
        public const string OSLRSTEMV = "OSLRSTEMV";

        /// <summary>
        /// OSLRSRSD.
        /// </summary>
        public const string OSLRSRSD = "OSLRSRSD";

        /// <summary>
        /// OSLRSRED.
        /// </summary>
        public const string OSLRSRED = "OSLRSRED";

        /// <summary>
        /// OSUSER.
        /// </summary>
        public const string OSUSER = "OSUSER";

        /// <summary>
        /// OSPID.
        /// </summary>
        public const string OSPID = "OSPID";

        /// <summary>
        /// OSJOBN.
        /// </summary>
        public const string OSJOBN = "OSJOBN";

        /// <summary>
        /// OSUPMJ.
        /// </summary>
        public const string OSUPMJ = "OSUPMJ";

        /// <summary>
        /// OSTDAY.
        /// </summary>
        public const string OSTDAY = "OSTDAY";

        /// <summary>
        /// OSCORCPH.
        /// </summary>
        public const string OSCORCPH = "OSCORCPH";

        /// <summary>
        /// OSSPACUSW1.
        /// </summary>
        public const string OSSPACUSW1 = "OSSPACUSW1";

        /// <summary>
        /// OSSPACUSW2.
        /// </summary>
        public const string OSSPACUSW2 = "OSSPACUSW2";

        /// <summary>
        /// OSSPACUSW3.
        /// </summary>
        public const string OSSPACUSW3 = "OSSPACUSW3";

        /// <summary>
        /// OSSPACUSW4.
        /// </summary>
        public const string OSSPACUSW4 = "OSSPACUSW4";

        /// <summary>
        /// OSSPADUSW1.
        /// </summary>
        public const string OSSPADUSW1 = "OSSPADUSW1";

        /// <summary>
        /// OSSPADUSW2.
        /// </summary>
        public const string OSSPADUSW2 = "OSSPADUSW2";

        /// <summary>
        /// OSSPADUSW3.
        /// </summary>
        public const string OSSPADUSW3 = "OSSPADUSW3";

        /// <summary>
        /// OSSPADUSW4.
        /// </summary>
        public const string OSSPADUSW4 = "OSSPADUSW4";

        /// <summary>
        /// OSSPANUSW1.
        /// </summary>
        public const string OSSPANUSW1 = "OSSPANUSW1";

        /// <summary>
        /// OSSPANUSW2.
        /// </summary>
        public const string OSSPANUSW2 = "OSSPANUSW2";

        /// <summary>
        /// OSSPANUSW3.
        /// </summary>
        public const string OSSPANUSW3 = "OSSPANUSW3";

        /// <summary>
        /// OSSPANUSW4.
        /// </summary>
        public const string OSSPANUSW4 = "OSSPANUSW4";

        /// <summary>
        /// OSSPASUSW1.
        /// </summary>
        public const string OSSPASUSW1 = "OSSPASUSW1";

        /// <summary>
        /// OSSPASUSW2.
        /// </summary>
        public const string OSSPASUSW2 = "OSSPASUSW2";

        /// <summary>
        /// OSSPASUSW3.
        /// </summary>
        public const string OSSPASUSW3 = "OSSPASUSW3";

        /// <summary>
        /// OSSPASUSW4.
        /// </summary>
        public const string OSSPASUSW4 = "OSSPASUSW4";
    }

    /// <inheritdoc />
    public override string TableName => "F186401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OSLRSORSID", "OSLRSORSID", JdeDataType.Numeric, null, true, true),
        new JdeField("OSLRSORSN", "OSLRSORSN", JdeDataType.String, 60),
        new JdeField("OSLRSEGID", "OSLRSEGID", JdeDataType.Numeric),
        new JdeField("OSLRSTEMV", "OSLRSTEMV", JdeDataType.String, 20),
        new JdeField("OSLRSRSD", "OSLRSRSD", JdeDataType.Numeric),
        new JdeField("OSLRSRED", "OSLRSRED", JdeDataType.Numeric),
        new JdeField("OSUSER", "OSUSER", JdeDataType.String, 20),
        new JdeField("OSPID", "OSPID", JdeDataType.String, 20),
        new JdeField("OSJOBN", "OSJOBN", JdeDataType.String, 20),
        new JdeField("OSUPMJ", "OSUPMJ", JdeDataType.Numeric),
        new JdeField("OSTDAY", "OSTDAY", JdeDataType.Numeric),
        new JdeField("OSCORCPH", "OSCORCPH", JdeDataType.Numeric),
        new JdeField("OSSPACUSW1", "OSSPACUSW1", JdeDataType.String, 2),
        new JdeField("OSSPACUSW2", "OSSPACUSW2", JdeDataType.String, 2),
        new JdeField("OSSPACUSW3", "OSSPACUSW3", JdeDataType.String, 2),
        new JdeField("OSSPACUSW4", "OSSPACUSW4", JdeDataType.String, 2),
        new JdeField("OSSPADUSW1", "OSSPADUSW1", JdeDataType.Numeric),
        new JdeField("OSSPADUSW2", "OSSPADUSW2", JdeDataType.Numeric),
        new JdeField("OSSPADUSW3", "OSSPADUSW3", JdeDataType.Numeric),
        new JdeField("OSSPADUSW4", "OSSPADUSW4", JdeDataType.Numeric),
        new JdeField("OSSPANUSW1", "OSSPANUSW1", JdeDataType.Numeric),
        new JdeField("OSSPANUSW2", "OSSPANUSW2", JdeDataType.Numeric),
        new JdeField("OSSPANUSW3", "OSSPANUSW3", JdeDataType.Numeric),
        new JdeField("OSSPANUSW4", "OSSPANUSW4", JdeDataType.Numeric),
        new JdeField("OSSPASUSW1", "OSSPASUSW1", JdeDataType.String, 60),
        new JdeField("OSSPASUSW2", "OSSPASUSW2", JdeDataType.String, 60),
        new JdeField("OSSPASUSW3", "OSSPASUSW3", JdeDataType.String, 60),
        new JdeField("OSSPASUSW4", "OSSPASUSW4", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186401_0", "Primary Key on OSLRSORSID", new[] { "OSLRSORSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186401_2", "Unique Index on OSLRSORSN", new[] { "OSLRSORSN" }, isUnique: true),
        new JdeIndex("F186401_3", "Index on OSLRSEGID", new[] { "OSLRSEGID" })
    };
}
