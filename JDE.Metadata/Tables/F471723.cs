using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F471723 - .
/// </summary>
public class F471723 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ECEDTY.
        /// </summary>
        public const string ECEDTY = "ECEDTY";

        /// <summary>
        /// ECEDSQ.
        /// </summary>
        public const string ECEDSQ = "ECEDSQ";

        /// <summary>
        /// ECEKCO.
        /// </summary>
        public const string ECEKCO = "ECEKCO";

        /// <summary>
        /// ECEDOC.
        /// </summary>
        public const string ECEDOC = "ECEDOC";

        /// <summary>
        /// ECEDCT.
        /// </summary>
        public const string ECEDCT = "ECEDCT";

        /// <summary>
        /// ECEDLN.
        /// </summary>
        public const string ECEDLN = "ECEDLN";

        /// <summary>
        /// ECEDST.
        /// </summary>
        public const string ECEDST = "ECEDST";

        /// <summary>
        /// ECEDFT.
        /// </summary>
        public const string ECEDFT = "ECEDFT";

        /// <summary>
        /// ECEDDT.
        /// </summary>
        public const string ECEDDT = "ECEDDT";

        /// <summary>
        /// ECEDER.
        /// </summary>
        public const string ECEDER = "ECEDER";

        /// <summary>
        /// ECEDDL.
        /// </summary>
        public const string ECEDDL = "ECEDDL";

        /// <summary>
        /// ECEDSP.
        /// </summary>
        public const string ECEDSP = "ECEDSP";

        /// <summary>
        /// ECEDBT.
        /// </summary>
        public const string ECEDBT = "ECEDBT";

        /// <summary>
        /// ECEDSLN.
        /// </summary>
        public const string ECEDSLN = "ECEDSLN";

        /// <summary>
        /// ECPARTYTYP.
        /// </summary>
        public const string ECPARTYTYP = "ECPARTYTYP";

        /// <summary>
        /// ECCONTTYP.
        /// </summary>
        public const string ECCONTTYP = "ECCONTTYP";

        /// <summary>
        /// ECCONTID.
        /// </summary>
        public const string ECCONTID = "ECCONTID";

        /// <summary>
        /// ECURCD.
        /// </summary>
        public const string ECURCD = "ECURCD";

        /// <summary>
        /// ECURDT.
        /// </summary>
        public const string ECURDT = "ECURDT";

        /// <summary>
        /// ECURAT.
        /// </summary>
        public const string ECURAT = "ECURAT";

        /// <summary>
        /// ECURAB.
        /// </summary>
        public const string ECURAB = "ECURAB";

        /// <summary>
        /// ECURRF.
        /// </summary>
        public const string ECURRF = "ECURRF";

        /// <summary>
        /// ECUSER.
        /// </summary>
        public const string ECUSER = "ECUSER";

        /// <summary>
        /// ECPID.
        /// </summary>
        public const string ECPID = "ECPID";

        /// <summary>
        /// ECJOBN.
        /// </summary>
        public const string ECJOBN = "ECJOBN";

        /// <summary>
        /// ECUPMJ.
        /// </summary>
        public const string ECUPMJ = "ECUPMJ";

        /// <summary>
        /// ECTDAY.
        /// </summary>
        public const string ECTDAY = "ECTDAY";

        /// <summary>
        /// ECWHO1.
        /// </summary>
        public const string ECWHO1 = "ECWHO1";
    }

    /// <inheritdoc />
    public override string TableName => "F471723";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ECEDTY", "ECEDTY", JdeDataType.String, 2),
        new JdeField("ECEDSQ", "ECEDSQ", JdeDataType.Numeric),
        new JdeField("ECEKCO", "ECEKCO", JdeDataType.String, 10, true, true),
        new JdeField("ECEDOC", "ECEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ECEDCT", "ECEDCT", JdeDataType.String, 4, true, true),
        new JdeField("ECEDLN", "ECEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ECEDST", "ECEDST", JdeDataType.String, 12),
        new JdeField("ECEDFT", "ECEDFT", JdeDataType.String, 20),
        new JdeField("ECEDDT", "ECEDDT", JdeDataType.Numeric),
        new JdeField("ECEDER", "ECEDER", JdeDataType.String, 2),
        new JdeField("ECEDDL", "ECEDDL", JdeDataType.Numeric),
        new JdeField("ECEDSP", "ECEDSP", JdeDataType.String, 2),
        new JdeField("ECEDBT", "ECEDBT", JdeDataType.String, 30),
        new JdeField("ECEDSLN", "ECEDSLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ECPARTYTYP", "ECPARTYTYP", JdeDataType.String, 6, true, true),
        new JdeField("ECCONTTYP", "ECCONTTYP", JdeDataType.String, 6, true, true),
        new JdeField("ECCONTID", "ECCONTID", JdeDataType.String, 70),
        new JdeField("ECURCD", "ECURCD", JdeDataType.String, 4),
        new JdeField("ECURDT", "ECURDT", JdeDataType.Numeric),
        new JdeField("ECURAT", "ECURAT", JdeDataType.Numeric),
        new JdeField("ECURAB", "ECURAB", JdeDataType.Numeric),
        new JdeField("ECURRF", "ECURRF", JdeDataType.String, 30),
        new JdeField("ECUSER", "ECUSER", JdeDataType.String, 20),
        new JdeField("ECPID", "ECPID", JdeDataType.String, 20),
        new JdeField("ECJOBN", "ECJOBN", JdeDataType.String, 20),
        new JdeField("ECUPMJ", "ECUPMJ", JdeDataType.Numeric),
        new JdeField("ECTDAY", "ECTDAY", JdeDataType.Numeric),
        new JdeField("ECWHO1", "ECWHO1", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F471723_0", "Primary Key on ECEDOC, ECEDCT, ECEKCO, ECEDLN, ECEDSLN, ECPARTYTYP, ECCONTTYP", new[] { "ECEDOC", "ECEDCT", "ECEKCO", "ECEDLN", "ECEDSLN", "ECPARTYTYP", "ECCONTTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
