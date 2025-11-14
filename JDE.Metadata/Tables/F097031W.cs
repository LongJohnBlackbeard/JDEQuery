using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F097031W - .
/// </summary>
public class F097031W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABUKID.
        /// </summary>
        public const string ABUKID = "ABUKID";

        /// <summary>
        /// ABAID.
        /// </summary>
        public const string ABAID = "ABAID";

        /// <summary>
        /// ABCTRY.
        /// </summary>
        public const string ABCTRY = "ABCTRY";

        /// <summary>
        /// ABFY.
        /// </summary>
        public const string ABFY = "ABFY";

        /// <summary>
        /// ABFQ.
        /// </summary>
        public const string ABFQ = "ABFQ";

        /// <summary>
        /// ABLT.
        /// </summary>
        public const string ABLT = "ABLT";

        /// <summary>
        /// ABSBL.
        /// </summary>
        public const string ABSBL = "ABSBL";

        /// <summary>
        /// ABSBLT.
        /// </summary>
        public const string ABSBLT = "ABSBLT";

        /// <summary>
        /// ABCRCD.
        /// </summary>
        public const string ABCRCD = "ABCRCD";

        /// <summary>
        /// ABABALCO.
        /// </summary>
        public const string ABABALCO = "ABABALCO";

        /// <summary>
        /// ABMCU.
        /// </summary>
        public const string ABMCU = "ABMCU";

        /// <summary>
        /// ABOBJ.
        /// </summary>
        public const string ABOBJ = "ABOBJ";

        /// <summary>
        /// ABSUB.
        /// </summary>
        public const string ABSUB = "ABSUB";

        /// <summary>
        /// ABAPYC.
        /// </summary>
        public const string ABAPYC = "ABAPYC";

        /// <summary>
        /// ABAN01.
        /// </summary>
        public const string ABAN01 = "ABAN01";

        /// <summary>
        /// ABAN02.
        /// </summary>
        public const string ABAN02 = "ABAN02";

        /// <summary>
        /// ABAN03.
        /// </summary>
        public const string ABAN03 = "ABAN03";

        /// <summary>
        /// ABAN04.
        /// </summary>
        public const string ABAN04 = "ABAN04";

        /// <summary>
        /// ABAN05.
        /// </summary>
        public const string ABAN05 = "ABAN05";

        /// <summary>
        /// ABAN06.
        /// </summary>
        public const string ABAN06 = "ABAN06";

        /// <summary>
        /// ABAN07.
        /// </summary>
        public const string ABAN07 = "ABAN07";

        /// <summary>
        /// ABAN08.
        /// </summary>
        public const string ABAN08 = "ABAN08";

        /// <summary>
        /// ABAN09.
        /// </summary>
        public const string ABAN09 = "ABAN09";

        /// <summary>
        /// ABAN10.
        /// </summary>
        public const string ABAN10 = "ABAN10";

        /// <summary>
        /// ABAN11.
        /// </summary>
        public const string ABAN11 = "ABAN11";

        /// <summary>
        /// ABAN12.
        /// </summary>
        public const string ABAN12 = "ABAN12";

        /// <summary>
        /// ABAN13.
        /// </summary>
        public const string ABAN13 = "ABAN13";

        /// <summary>
        /// ABAN14.
        /// </summary>
        public const string ABAN14 = "ABAN14";

        /// <summary>
        /// ABAMCO.
        /// </summary>
        public const string ABAMCO = "ABAMCO";

        /// <summary>
        /// ABCRCX.
        /// </summary>
        public const string ABCRCX = "ABCRCX";
    }

    /// <inheritdoc />
    public override string TableName => "F097031W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20, true, true),
        new JdeField("ABUKID", "ABUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ABAID", "ABAID", JdeDataType.String, 16, true, true),
        new JdeField("ABCTRY", "ABCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("ABFY", "ABFY", JdeDataType.Numeric, null, true, true),
        new JdeField("ABFQ", "ABFQ", JdeDataType.String, 8, true, true),
        new JdeField("ABLT", "ABLT", JdeDataType.String, 4, true, true),
        new JdeField("ABSBL", "ABSBL", JdeDataType.String, 16, true, true),
        new JdeField("ABSBLT", "ABSBLT", JdeDataType.String, 2, true, true),
        new JdeField("ABCRCD", "ABCRCD", JdeDataType.String, 6, true, true),
        new JdeField("ABABALCO", "ABABALCO", JdeDataType.String, 10),
        new JdeField("ABMCU", "ABMCU", JdeDataType.String, 24),
        new JdeField("ABOBJ", "ABOBJ", JdeDataType.String, 12),
        new JdeField("ABSUB", "ABSUB", JdeDataType.String, 16),
        new JdeField("ABAPYC", "ABAPYC", JdeDataType.Numeric),
        new JdeField("ABAN01", "ABAN01", JdeDataType.Numeric),
        new JdeField("ABAN02", "ABAN02", JdeDataType.Numeric),
        new JdeField("ABAN03", "ABAN03", JdeDataType.Numeric),
        new JdeField("ABAN04", "ABAN04", JdeDataType.Numeric),
        new JdeField("ABAN05", "ABAN05", JdeDataType.Numeric),
        new JdeField("ABAN06", "ABAN06", JdeDataType.Numeric),
        new JdeField("ABAN07", "ABAN07", JdeDataType.Numeric),
        new JdeField("ABAN08", "ABAN08", JdeDataType.Numeric),
        new JdeField("ABAN09", "ABAN09", JdeDataType.Numeric),
        new JdeField("ABAN10", "ABAN10", JdeDataType.Numeric),
        new JdeField("ABAN11", "ABAN11", JdeDataType.Numeric),
        new JdeField("ABAN12", "ABAN12", JdeDataType.Numeric),
        new JdeField("ABAN13", "ABAN13", JdeDataType.Numeric),
        new JdeField("ABAN14", "ABAN14", JdeDataType.Numeric),
        new JdeField("ABAMCO", "ABAMCO", JdeDataType.String, 10),
        new JdeField("ABCRCX", "ABCRCX", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F097031W_0", "Primary Key on ABUSER, ABUKID, ABAID, ABCTRY, ABFY, ABFQ, ABLT, ABSBL, ABSBLT, ABCRCD", new[] { "ABUSER", "ABUKID", "ABAID", "ABCTRY", "ABFY", "ABFQ", "ABLT", "ABSBL", "ABSBLT", "ABCRCD" }, isUnique: true, isPrimaryKey: true)
    };
}
