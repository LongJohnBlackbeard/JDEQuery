using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A710C - .
/// </summary>
public class F75A710C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISTAXX.
        /// </summary>
        public const string ISTAXX = "ISTAXX";

        /// <summary>
        /// ISGRPNO.
        /// </summary>
        public const string ISGRPNO = "ISGRPNO";

        /// <summary>
        /// ISASSPD.
        /// </summary>
        public const string ISASSPD = "ISASSPD";

        /// <summary>
        /// ISASSQ.
        /// </summary>
        public const string ISASSQ = "ISASSQ";

        /// <summary>
        /// ISAN8.
        /// </summary>
        public const string ISAN8 = "ISAN8";

        /// <summary>
        /// ISISYC.
        /// </summary>
        public const string ISISYC = "ISISYC";

        /// <summary>
        /// ISCNOD.
        /// </summary>
        public const string ISCNOD = "ISCNOD";

        /// <summary>
        /// ISTXTC.
        /// </summary>
        public const string ISTXTC = "ISTXTC";

        /// <summary>
        /// ISHMCO.
        /// </summary>
        public const string ISHMCO = "ISHMCO";

        /// <summary>
        /// ISPPAI.
        /// </summary>
        public const string ISPPAI = "ISPPAI";

        /// <summary>
        /// ISG101.
        /// </summary>
        public const string ISG101 = "ISG101";

        /// <summary>
        /// ISASCDP.
        /// </summary>
        public const string ISASCDP = "ISASCDP";

        /// <summary>
        /// ISASPYG.
        /// </summary>
        public const string ISASPYG = "ISASPYG";

        /// <summary>
        /// ISASFIA.
        /// </summary>
        public const string ISASFIA = "ISASFIA";

        /// <summary>
        /// ISASFPG.
        /// </summary>
        public const string ISASFPG = "ISASFPG";

        /// <summary>
        /// ISOTMA.
        /// </summary>
        public const string ISOTMA = "ISOTMA";

        /// <summary>
        /// ISBOCO.
        /// </summary>
        public const string ISBOCO = "ISBOCO";

        /// <summary>
        /// ISDIFE.
        /// </summary>
        public const string ISDIFE = "ISDIFE";

        /// <summary>
        /// ISTOFT.
        /// </summary>
        public const string ISTOFT = "ISTOFT";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISUPMT.
        /// </summary>
        public const string ISUPMT = "ISUPMT";

        /// <summary>
        /// ISPID.
        /// </summary>
        public const string ISPID = "ISPID";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISSPACAUU1.
        /// </summary>
        public const string ISSPACAUU1 = "ISSPACAUU1";

        /// <summary>
        /// ISSPACAUU2.
        /// </summary>
        public const string ISSPACAUU2 = "ISSPACAUU2";

        /// <summary>
        /// ISSPACAUU3.
        /// </summary>
        public const string ISSPACAUU3 = "ISSPACAUU3";

        /// <summary>
        /// ISSPACAUU4.
        /// </summary>
        public const string ISSPACAUU4 = "ISSPACAUU4";

        /// <summary>
        /// ISSPADAUU1.
        /// </summary>
        public const string ISSPADAUU1 = "ISSPADAUU1";

        /// <summary>
        /// ISSPADAUU2.
        /// </summary>
        public const string ISSPADAUU2 = "ISSPADAUU2";

        /// <summary>
        /// ISSPADAUU3.
        /// </summary>
        public const string ISSPADAUU3 = "ISSPADAUU3";

        /// <summary>
        /// ISSPADAUU4.
        /// </summary>
        public const string ISSPADAUU4 = "ISSPADAUU4";

        /// <summary>
        /// ISSPANAUU1.
        /// </summary>
        public const string ISSPANAUU1 = "ISSPANAUU1";

        /// <summary>
        /// ISSPANAUU2.
        /// </summary>
        public const string ISSPANAUU2 = "ISSPANAUU2";

        /// <summary>
        /// ISSPANAUU3.
        /// </summary>
        public const string ISSPANAUU3 = "ISSPANAUU3";

        /// <summary>
        /// ISSPANAUU4.
        /// </summary>
        public const string ISSPANAUU4 = "ISSPANAUU4";

        /// <summary>
        /// ISSPASAUU1.
        /// </summary>
        public const string ISSPASAUU1 = "ISSPASAUU1";

        /// <summary>
        /// ISSPASAUU2.
        /// </summary>
        public const string ISSPASAUU2 = "ISSPASAUU2";

        /// <summary>
        /// ISSPASAUU3.
        /// </summary>
        public const string ISSPASAUU3 = "ISSPASAUU3";

        /// <summary>
        /// ISSPASAUU4.
        /// </summary>
        public const string ISSPASAUU4 = "ISSPASAUU4";
    }

    /// <inheritdoc />
    public override string TableName => "F75A710C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISTAXX", "ISTAXX", JdeDataType.String, 40, true, true),
        new JdeField("ISGRPNO", "ISGRPNO", JdeDataType.String, 22, true, true),
        new JdeField("ISASSPD", "ISASSPD", JdeDataType.Numeric, null, true, true),
        new JdeField("ISASSQ", "ISASSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ISAN8", "ISAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ISISYC", "ISISYC", JdeDataType.String, 6, true, true),
        new JdeField("ISCNOD", "ISCNOD", JdeDataType.String, 4, true, true),
        new JdeField("ISTXTC", "ISTXTC", JdeDataType.String, 12),
        new JdeField("ISHMCO", "ISHMCO", JdeDataType.String, 10),
        new JdeField("ISPPAI", "ISPPAI", JdeDataType.Numeric),
        new JdeField("ISG101", "ISG101", JdeDataType.Numeric),
        new JdeField("ISASCDP", "ISASCDP", JdeDataType.Numeric),
        new JdeField("ISASPYG", "ISASPYG", JdeDataType.Numeric),
        new JdeField("ISASFIA", "ISASFIA", JdeDataType.Numeric),
        new JdeField("ISASFPG", "ISASFPG", JdeDataType.Numeric),
        new JdeField("ISOTMA", "ISOTMA", JdeDataType.Numeric),
        new JdeField("ISBOCO", "ISBOCO", JdeDataType.Numeric),
        new JdeField("ISDIFE", "ISDIFE", JdeDataType.Numeric),
        new JdeField("ISTOFT", "ISTOFT", JdeDataType.Numeric),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISUPMT", "ISUPMT", JdeDataType.Numeric),
        new JdeField("ISPID", "ISPID", JdeDataType.String, 20),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISSPACAUU1", "ISSPACAUU1", JdeDataType.String, 2),
        new JdeField("ISSPACAUU2", "ISSPACAUU2", JdeDataType.String, 2),
        new JdeField("ISSPACAUU3", "ISSPACAUU3", JdeDataType.String, 2),
        new JdeField("ISSPACAUU4", "ISSPACAUU4", JdeDataType.String, 2),
        new JdeField("ISSPADAUU1", "ISSPADAUU1", JdeDataType.Numeric),
        new JdeField("ISSPADAUU2", "ISSPADAUU2", JdeDataType.Numeric),
        new JdeField("ISSPADAUU3", "ISSPADAUU3", JdeDataType.Numeric),
        new JdeField("ISSPADAUU4", "ISSPADAUU4", JdeDataType.Numeric),
        new JdeField("ISSPANAUU1", "ISSPANAUU1", JdeDataType.Numeric),
        new JdeField("ISSPANAUU2", "ISSPANAUU2", JdeDataType.Numeric),
        new JdeField("ISSPANAUU3", "ISSPANAUU3", JdeDataType.Numeric),
        new JdeField("ISSPANAUU4", "ISSPANAUU4", JdeDataType.Numeric),
        new JdeField("ISSPASAUU1", "ISSPASAUU1", JdeDataType.String, 60),
        new JdeField("ISSPASAUU2", "ISSPASAUU2", JdeDataType.String, 60),
        new JdeField("ISSPASAUU3", "ISSPASAUU3", JdeDataType.String, 60),
        new JdeField("ISSPASAUU4", "ISSPASAUU4", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A710C_0", "Primary Key on ISTAXX, ISGRPNO, ISASSPD, ISASSQ, ISAN8, ISISYC, ISCNOD", new[] { "ISTAXX", "ISGRPNO", "ISASSPD", "ISASSQ", "ISAN8", "ISISYC", "ISCNOD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A710C_2", "Index on ISTAXX, ISGRPNO, SYS_NC00041$, SYS_NC00042$", new[] { "ISTAXX", "ISGRPNO", "SYS_NC00041$", "SYS_NC00042$" })
    };
}
