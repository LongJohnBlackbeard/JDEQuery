using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4972 - .
/// </summary>
public class F4972 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RXRTNM.
        /// </summary>
        public const string RXRTNM = "RXRTNM";

        /// <summary>
        /// RXORGN.
        /// </summary>
        public const string RXORGN = "RXORGN";

        /// <summary>
        /// RXSHAN.
        /// </summary>
        public const string RXSHAN = "RXSHAN";

        /// <summary>
        /// RXICID.
        /// </summary>
        public const string RXICID = "RXICID";

        /// <summary>
        /// RXCARS.
        /// </summary>
        public const string RXCARS = "RXCARS";

        /// <summary>
        /// RXCRCD.
        /// </summary>
        public const string RXCRCD = "RXCRCD";

        /// <summary>
        /// RXNMFC.
        /// </summary>
        public const string RXNMFC = "RXNMFC";

        /// <summary>
        /// RXDSGP.
        /// </summary>
        public const string RXDSGP = "RXDSGP";

        /// <summary>
        /// RXFRT1.
        /// </summary>
        public const string RXFRT1 = "RXFRT1";

        /// <summary>
        /// RXFRT2.
        /// </summary>
        public const string RXFRT2 = "RXFRT2";

        /// <summary>
        /// RXEFTJ.
        /// </summary>
        public const string RXEFTJ = "RXEFTJ";

        /// <summary>
        /// RXEXDJ.
        /// </summary>
        public const string RXEXDJ = "RXEXDJ";

        /// <summary>
        /// RXNTE1.
        /// </summary>
        public const string RXNTE1 = "RXNTE1";

        /// <summary>
        /// RXNTE2.
        /// </summary>
        public const string RXNTE2 = "RXNTE2";

        /// <summary>
        /// RXFRCG.
        /// </summary>
        public const string RXFRCG = "RXFRCG";

        /// <summary>
        /// RXVBT.
        /// </summary>
        public const string RXVBT = "RXVBT";

        /// <summary>
        /// RXFRMN.
        /// </summary>
        public const string RXFRMN = "RXFRMN";

        /// <summary>
        /// RXUKID.
        /// </summary>
        public const string RXUKID = "RXUKID";

        /// <summary>
        /// RXIBOB.
        /// </summary>
        public const string RXIBOB = "RXIBOB";

        /// <summary>
        /// RXURCD.
        /// </summary>
        public const string RXURCD = "RXURCD";

        /// <summary>
        /// RXURDT.
        /// </summary>
        public const string RXURDT = "RXURDT";

        /// <summary>
        /// RXURAT.
        /// </summary>
        public const string RXURAT = "RXURAT";

        /// <summary>
        /// RXURAB.
        /// </summary>
        public const string RXURAB = "RXURAB";

        /// <summary>
        /// RXURRF.
        /// </summary>
        public const string RXURRF = "RXURRF";

        /// <summary>
        /// RXUSER.
        /// </summary>
        public const string RXUSER = "RXUSER";

        /// <summary>
        /// RXPID.
        /// </summary>
        public const string RXPID = "RXPID";

        /// <summary>
        /// RXJOBN.
        /// </summary>
        public const string RXJOBN = "RXJOBN";

        /// <summary>
        /// RXUPMJ.
        /// </summary>
        public const string RXUPMJ = "RXUPMJ";

        /// <summary>
        /// RXTDAY.
        /// </summary>
        public const string RXTDAY = "RXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4972";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RXRTNM", "RXRTNM", JdeDataType.String, 20),
        new JdeField("RXORGN", "RXORGN", JdeDataType.Numeric),
        new JdeField("RXSHAN", "RXSHAN", JdeDataType.Numeric),
        new JdeField("RXICID", "RXICID", JdeDataType.Numeric),
        new JdeField("RXCARS", "RXCARS", JdeDataType.Numeric),
        new JdeField("RXCRCD", "RXCRCD", JdeDataType.String, 6),
        new JdeField("RXNMFC", "RXNMFC", JdeDataType.String, 8),
        new JdeField("RXDSGP", "RXDSGP", JdeDataType.String, 6),
        new JdeField("RXFRT1", "RXFRT1", JdeDataType.String, 12),
        new JdeField("RXFRT2", "RXFRT2", JdeDataType.String, 12),
        new JdeField("RXEFTJ", "RXEFTJ", JdeDataType.Numeric),
        new JdeField("RXEXDJ", "RXEXDJ", JdeDataType.Numeric),
        new JdeField("RXNTE1", "RXNTE1", JdeDataType.Numeric),
        new JdeField("RXNTE2", "RXNTE2", JdeDataType.Numeric),
        new JdeField("RXFRCG", "RXFRCG", JdeDataType.Numeric),
        new JdeField("RXVBT", "RXVBT", JdeDataType.String, 20),
        new JdeField("RXFRMN", "RXFRMN", JdeDataType.String, 20),
        new JdeField("RXUKID", "RXUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RXIBOB", "RXIBOB", JdeDataType.String, 2),
        new JdeField("RXURCD", "RXURCD", JdeDataType.String, 4),
        new JdeField("RXURDT", "RXURDT", JdeDataType.Numeric),
        new JdeField("RXURAT", "RXURAT", JdeDataType.Numeric),
        new JdeField("RXURAB", "RXURAB", JdeDataType.Numeric),
        new JdeField("RXURRF", "RXURRF", JdeDataType.String, 30),
        new JdeField("RXUSER", "RXUSER", JdeDataType.String, 20),
        new JdeField("RXPID", "RXPID", JdeDataType.String, 20),
        new JdeField("RXJOBN", "RXJOBN", JdeDataType.String, 20),
        new JdeField("RXUPMJ", "RXUPMJ", JdeDataType.Numeric),
        new JdeField("RXTDAY", "RXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4972_0", "Primary Key on RXUKID", new[] { "RXUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4972_10", "Index on RXRTNM, RXNMFC, RXDSGP, RXFRT1, RXFRT2, RXNTE1, RXNTE2, RXCARS, RXCRCD, SYS_NC00030$", new[] { "RXRTNM", "RXNMFC", "RXDSGP", "RXFRT1", "RXFRT2", "RXNTE1", "RXNTE2", "RXCARS", "RXCRCD", "SYS_NC00030$" }),
        new JdeIndex("F4972_11", "Index on RXRTNM, RXORGN, RXSHAN, RXCARS, RXCRCD, RXNMFC, RXDSGP, RXFRT1, RXFRT2, RXEFTJ", new[] { "RXRTNM", "RXORGN", "RXSHAN", "RXCARS", "RXCRCD", "RXNMFC", "RXDSGP", "RXFRT1", "RXFRT2", "RXEFTJ" }),
        new JdeIndex("F4972_12", "Index on RXRTNM, RXORGN, RXSHAN, RXCARS, RXCRCD, RXNMFC, RXDSGP, RXEFTJ, RXNTE2, RXNTE1", new[] { "RXRTNM", "RXORGN", "RXSHAN", "RXCARS", "RXCRCD", "RXNMFC", "RXDSGP", "RXEFTJ", "RXNTE2", "RXNTE1" }),
        new JdeIndex("F4972_3", "Index on RXRTNM, RXEFTJ", new[] { "RXRTNM", "RXEFTJ" }),
        new JdeIndex("F4972_4", "Unique Index on SYS_NC00031$", new[] { "SYS_NC00031$" }, isUnique: true),
        new JdeIndex("F4972_5", "Index on RXRTNM, RXORGN, RXSHAN, RXCARS, RXCRCD, RXEFTJ, RXEXDJ, RXNTE1, RXNTE2", new[] { "RXRTNM", "RXORGN", "RXSHAN", "RXCARS", "RXCRCD", "RXEFTJ", "RXEXDJ", "RXNTE1", "RXNTE2" }),
        new JdeIndex("F4972_6", "Index on RXRTNM, RXNMFC, RXDSGP, RXFRT1, RXFRT2, RXNTE1, RXNTE2, RXORGN, RXSHAN, SYS_NC00030$", new[] { "RXRTNM", "RXNMFC", "RXDSGP", "RXFRT1", "RXFRT2", "RXNTE1", "RXNTE2", "RXORGN", "RXSHAN", "SYS_NC00030$" }),
        new JdeIndex("F4972_8", "Index on RXRTNM, RXNMFC, RXDSGP, RXFRT1, RXFRT2, RXNTE1, RXNTE2, RXORGN, RXCARS, SYS_NC00030$", new[] { "RXRTNM", "RXNMFC", "RXDSGP", "RXFRT1", "RXFRT2", "RXNTE1", "RXNTE2", "RXORGN", "RXCARS", "SYS_NC00030$" }),
        new JdeIndex("F4972_9", "Index on RXRTNM, RXNMFC, RXDSGP, RXFRT1, RXFRT2, RXNTE1, RXNTE2, RXSHAN, RXCRCD, SYS_NC00030$", new[] { "RXRTNM", "RXNMFC", "RXDSGP", "RXFRT1", "RXFRT2", "RXNTE1", "RXNTE2", "RXSHAN", "RXCRCD", "SYS_NC00030$" })
    };
}
