using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0902 - .
/// </summary>
public class F76C0902 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GBAID.
        /// </summary>
        public const string GBAID = "GBAID";

        /// <summary>
        /// GBCTRY.
        /// </summary>
        public const string GBCTRY = "GBCTRY";

        /// <summary>
        /// GBFY.
        /// </summary>
        public const string GBFY = "GBFY";

        /// <summary>
        /// GBPN.
        /// </summary>
        public const string GBPN = "GBPN";

        /// <summary>
        /// GBLT.
        /// </summary>
        public const string GBLT = "GBLT";

        /// <summary>
        /// GBSBL.
        /// </summary>
        public const string GBSBL = "GBSBL";

        /// <summary>
        /// GBCO.
        /// </summary>
        public const string GBCO = "GBCO";

        /// <summary>
        /// GBAN01.
        /// </summary>
        public const string GBAN01 = "GBAN01";

        /// <summary>
        /// GBAN02.
        /// </summary>
        public const string GBAN02 = "GBAN02";

        /// <summary>
        /// GBAN03.
        /// </summary>
        public const string GBAN03 = "GBAN03";

        /// <summary>
        /// GBAN04.
        /// </summary>
        public const string GBAN04 = "GBAN04";

        /// <summary>
        /// GBMCU.
        /// </summary>
        public const string GBMCU = "GBMCU";

        /// <summary>
        /// GBOBJ.
        /// </summary>
        public const string GBOBJ = "GBOBJ";

        /// <summary>
        /// GBSUB.
        /// </summary>
        public const string GBSUB = "GBSUB";

        /// <summary>
        /// GBUSER.
        /// </summary>
        public const string GBUSER = "GBUSER";

        /// <summary>
        /// GBPID.
        /// </summary>
        public const string GBPID = "GBPID";

        /// <summary>
        /// GBUPMJ.
        /// </summary>
        public const string GBUPMJ = "GBUPMJ";

        /// <summary>
        /// GBJOBN.
        /// </summary>
        public const string GBJOBN = "GBJOBN";

        /// <summary>
        /// GBSBLT.
        /// </summary>
        public const string GBSBLT = "GBSBLT";

        /// <summary>
        /// GBCRCD.
        /// </summary>
        public const string GBCRCD = "GBCRCD";

        /// <summary>
        /// GBCRCX.
        /// </summary>
        public const string GBCRCX = "GBCRCX";

        /// <summary>
        /// GBN002.
        /// </summary>
        public const string GBN002 = "GBN002";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0902";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GBAID", "GBAID", JdeDataType.String, 16, true, true),
        new JdeField("GBCTRY", "GBCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("GBFY", "GBFY", JdeDataType.Numeric, null, true, true),
        new JdeField("GBPN", "GBPN", JdeDataType.Numeric, null, true, true),
        new JdeField("GBLT", "GBLT", JdeDataType.String, 4, true, true),
        new JdeField("GBSBL", "GBSBL", JdeDataType.String, 16, true, true),
        new JdeField("GBCO", "GBCO", JdeDataType.String, 10, true, true),
        new JdeField("GBAN01", "GBAN01", JdeDataType.Numeric),
        new JdeField("GBAN02", "GBAN02", JdeDataType.Numeric),
        new JdeField("GBAN03", "GBAN03", JdeDataType.Numeric),
        new JdeField("GBAN04", "GBAN04", JdeDataType.Numeric),
        new JdeField("GBMCU", "GBMCU", JdeDataType.String, 24),
        new JdeField("GBOBJ", "GBOBJ", JdeDataType.String, 12),
        new JdeField("GBSUB", "GBSUB", JdeDataType.String, 16),
        new JdeField("GBUSER", "GBUSER", JdeDataType.String, 20, true, true),
        new JdeField("GBPID", "GBPID", JdeDataType.String, 20),
        new JdeField("GBUPMJ", "GBUPMJ", JdeDataType.Numeric),
        new JdeField("GBJOBN", "GBJOBN", JdeDataType.String, 20),
        new JdeField("GBSBLT", "GBSBLT", JdeDataType.String, 2, true, true),
        new JdeField("GBCRCD", "GBCRCD", JdeDataType.String, 6, true, true),
        new JdeField("GBCRCX", "GBCRCX", JdeDataType.String, 6),
        new JdeField("GBN002", "GBN002", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0902_0", "Primary Key on GBCO, GBAID, GBCTRY, GBFY, GBPN, GBSBL, GBLT, GBSBLT, GBCRCD, GBUSER, GBN002", new[] { "GBCO", "GBAID", "GBCTRY", "GBFY", "GBPN", "GBSBL", "GBLT", "GBSBLT", "GBCRCD", "GBUSER", "GBN002" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C0902_2", "Index on GBUSER, GBCTRY, GBFY, GBPN, GBCO", new[] { "GBUSER", "GBCTRY", "GBFY", "GBPN", "GBCO" })
    };
}
