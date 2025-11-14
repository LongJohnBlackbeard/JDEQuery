using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51X0902 - .
/// </summary>
public class F51X0902 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LBUSER.
        /// </summary>
        public const string LBUSER = "LBUSER";

        /// <summary>
        /// LBJOBS.
        /// </summary>
        public const string LBJOBS = "LBJOBS";

        /// <summary>
        /// LBMCU.
        /// </summary>
        public const string LBMCU = "LBMCU";

        /// <summary>
        /// LBAID.
        /// </summary>
        public const string LBAID = "LBAID";

        /// <summary>
        /// LBCTRY.
        /// </summary>
        public const string LBCTRY = "LBCTRY";

        /// <summary>
        /// LBFY.
        /// </summary>
        public const string LBFY = "LBFY";

        /// <summary>
        /// LBLT.
        /// </summary>
        public const string LBLT = "LBLT";

        /// <summary>
        /// LBSBL.
        /// </summary>
        public const string LBSBL = "LBSBL";

        /// <summary>
        /// LBSBLT.
        /// </summary>
        public const string LBSBLT = "LBSBLT";

        /// <summary>
        /// LBCRCD.
        /// </summary>
        public const string LBCRCD = "LBCRCD";

        /// <summary>
        /// LBCRCX.
        /// </summary>
        public const string LBCRCX = "LBCRCX";

        /// <summary>
        /// LBAPYC.
        /// </summary>
        public const string LBAPYC = "LBAPYC";

        /// <summary>
        /// LBAN01.
        /// </summary>
        public const string LBAN01 = "LBAN01";

        /// <summary>
        /// LBAN02.
        /// </summary>
        public const string LBAN02 = "LBAN02";

        /// <summary>
        /// LBAN03.
        /// </summary>
        public const string LBAN03 = "LBAN03";

        /// <summary>
        /// LBAN04.
        /// </summary>
        public const string LBAN04 = "LBAN04";

        /// <summary>
        /// LBAN05.
        /// </summary>
        public const string LBAN05 = "LBAN05";

        /// <summary>
        /// LBAN06.
        /// </summary>
        public const string LBAN06 = "LBAN06";

        /// <summary>
        /// LBAN07.
        /// </summary>
        public const string LBAN07 = "LBAN07";

        /// <summary>
        /// LBAN08.
        /// </summary>
        public const string LBAN08 = "LBAN08";

        /// <summary>
        /// LBAN09.
        /// </summary>
        public const string LBAN09 = "LBAN09";

        /// <summary>
        /// LBAN10.
        /// </summary>
        public const string LBAN10 = "LBAN10";

        /// <summary>
        /// LBAN11.
        /// </summary>
        public const string LBAN11 = "LBAN11";

        /// <summary>
        /// LBAN12.
        /// </summary>
        public const string LBAN12 = "LBAN12";

        /// <summary>
        /// LBAN13.
        /// </summary>
        public const string LBAN13 = "LBAN13";

        /// <summary>
        /// LBAN14.
        /// </summary>
        public const string LBAN14 = "LBAN14";

        /// <summary>
        /// LBBORG.
        /// </summary>
        public const string LBBORG = "LBBORG";
    }

    /// <inheritdoc />
    public override string TableName => "F51X0902";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LBUSER", "LBUSER", JdeDataType.String, 20, true, true),
        new JdeField("LBJOBS", "LBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("LBMCU", "LBMCU", JdeDataType.String, 24, true, true),
        new JdeField("LBAID", "LBAID", JdeDataType.String, 16, true, true),
        new JdeField("LBCTRY", "LBCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("LBFY", "LBFY", JdeDataType.Numeric, null, true, true),
        new JdeField("LBLT", "LBLT", JdeDataType.String, 4, true, true),
        new JdeField("LBSBL", "LBSBL", JdeDataType.String, 16),
        new JdeField("LBSBLT", "LBSBLT", JdeDataType.String, 2),
        new JdeField("LBCRCD", "LBCRCD", JdeDataType.String, 6),
        new JdeField("LBCRCX", "LBCRCX", JdeDataType.String, 6),
        new JdeField("LBAPYC", "LBAPYC", JdeDataType.Numeric),
        new JdeField("LBAN01", "LBAN01", JdeDataType.Numeric),
        new JdeField("LBAN02", "LBAN02", JdeDataType.Numeric),
        new JdeField("LBAN03", "LBAN03", JdeDataType.Numeric),
        new JdeField("LBAN04", "LBAN04", JdeDataType.Numeric),
        new JdeField("LBAN05", "LBAN05", JdeDataType.Numeric),
        new JdeField("LBAN06", "LBAN06", JdeDataType.Numeric),
        new JdeField("LBAN07", "LBAN07", JdeDataType.Numeric),
        new JdeField("LBAN08", "LBAN08", JdeDataType.Numeric),
        new JdeField("LBAN09", "LBAN09", JdeDataType.Numeric),
        new JdeField("LBAN10", "LBAN10", JdeDataType.Numeric),
        new JdeField("LBAN11", "LBAN11", JdeDataType.Numeric),
        new JdeField("LBAN12", "LBAN12", JdeDataType.Numeric),
        new JdeField("LBAN13", "LBAN13", JdeDataType.Numeric),
        new JdeField("LBAN14", "LBAN14", JdeDataType.Numeric),
        new JdeField("LBBORG", "LBBORG", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51X0902_0", "Primary Key on LBUSER, LBJOBS, LBMCU, LBAID, LBCTRY, LBFY, LBLT", new[] { "LBUSER", "LBJOBS", "LBMCU", "LBAID", "LBCTRY", "LBFY", "LBLT" }, isUnique: true, isPrimaryKey: true)
    };
}
