using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J0006 - .
/// </summary>
public class F09J0006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JBCO.
        /// </summary>
        public const string JBCO = "JBCO";

        /// <summary>
        /// JBMCUS.
        /// </summary>
        public const string JBMCUS = "JBMCUS";

        /// <summary>
        /// JBMCU.
        /// </summary>
        public const string JBMCU = "JBMCU";

        /// <summary>
        /// JBJVRMCU.
        /// </summary>
        public const string JBJVRMCU = "JBJVRMCU";

        /// <summary>
        /// JBJVRMK.
        /// </summary>
        public const string JBJVRMK = "JBJVRMK";

        /// <summary>
        /// JBJVANOV.
        /// </summary>
        public const string JBJVANOV = "JBJVANOV";

        /// <summary>
        /// JBJVCOH.
        /// </summary>
        public const string JBJVCOH = "JBJVCOH";

        /// <summary>
        /// JBJVINDATE.
        /// </summary>
        public const string JBJVINDATE = "JBJVINDATE";

        /// <summary>
        /// JBTORG.
        /// </summary>
        public const string JBTORG = "JBTORG";

        /// <summary>
        /// JBENTJ.
        /// </summary>
        public const string JBENTJ = "JBENTJ";

        /// <summary>
        /// JBUSER.
        /// </summary>
        public const string JBUSER = "JBUSER";

        /// <summary>
        /// JBMKEY.
        /// </summary>
        public const string JBMKEY = "JBMKEY";

        /// <summary>
        /// JBPID.
        /// </summary>
        public const string JBPID = "JBPID";

        /// <summary>
        /// JBUPMJ.
        /// </summary>
        public const string JBUPMJ = "JBUPMJ";

        /// <summary>
        /// JBUPMT.
        /// </summary>
        public const string JBUPMT = "JBUPMT";

        /// <summary>
        /// JBURNUMB01.
        /// </summary>
        public const string JBURNUMB01 = "JBURNUMB01";

        /// <summary>
        /// JBURNUMB02.
        /// </summary>
        public const string JBURNUMB02 = "JBURNUMB02";

        /// <summary>
        /// JBURNUMB03.
        /// </summary>
        public const string JBURNUMB03 = "JBURNUMB03";

        /// <summary>
        /// JBURNUMB04.
        /// </summary>
        public const string JBURNUMB04 = "JBURNUMB04";

        /// <summary>
        /// JBURNUMB05.
        /// </summary>
        public const string JBURNUMB05 = "JBURNUMB05";

        /// <summary>
        /// JBURATJB01.
        /// </summary>
        public const string JBURATJB01 = "JBURATJB01";

        /// <summary>
        /// JBURATJB02.
        /// </summary>
        public const string JBURATJB02 = "JBURATJB02";

        /// <summary>
        /// JBURATJB03.
        /// </summary>
        public const string JBURATJB03 = "JBURATJB03";

        /// <summary>
        /// JBURATJB04.
        /// </summary>
        public const string JBURATJB04 = "JBURATJB04";

        /// <summary>
        /// JBURATJB05.
        /// </summary>
        public const string JBURATJB05 = "JBURATJB05";

        /// <summary>
        /// JBURCDJB01.
        /// </summary>
        public const string JBURCDJB01 = "JBURCDJB01";

        /// <summary>
        /// JBURCDJB02.
        /// </summary>
        public const string JBURCDJB02 = "JBURCDJB02";

        /// <summary>
        /// JBURCDJB03.
        /// </summary>
        public const string JBURCDJB03 = "JBURCDJB03";

        /// <summary>
        /// JBURCDJB04.
        /// </summary>
        public const string JBURCDJB04 = "JBURCDJB04";

        /// <summary>
        /// JBURCDJB05.
        /// </summary>
        public const string JBURCDJB05 = "JBURCDJB05";

        /// <summary>
        /// JBURRFJB01.
        /// </summary>
        public const string JBURRFJB01 = "JBURRFJB01";

        /// <summary>
        /// JBURRFJB02.
        /// </summary>
        public const string JBURRFJB02 = "JBURRFJB02";

        /// <summary>
        /// JBURRFJB03.
        /// </summary>
        public const string JBURRFJB03 = "JBURRFJB03";

        /// <summary>
        /// JBURRFJB04.
        /// </summary>
        public const string JBURRFJB04 = "JBURRFJB04";

        /// <summary>
        /// JBURRFJB05.
        /// </summary>
        public const string JBURRFJB05 = "JBURRFJB05";

        /// <summary>
        /// JBURSTJB01.
        /// </summary>
        public const string JBURSTJB01 = "JBURSTJB01";

        /// <summary>
        /// JBURSTJB02.
        /// </summary>
        public const string JBURSTJB02 = "JBURSTJB02";

        /// <summary>
        /// JBURSTJB03.
        /// </summary>
        public const string JBURSTJB03 = "JBURSTJB03";

        /// <summary>
        /// JBURSTJB04.
        /// </summary>
        public const string JBURSTJB04 = "JBURSTJB04";

        /// <summary>
        /// JBURSTJB05.
        /// </summary>
        public const string JBURSTJB05 = "JBURSTJB05";

        /// <summary>
        /// JBURDTJB01.
        /// </summary>
        public const string JBURDTJB01 = "JBURDTJB01";

        /// <summary>
        /// JBURDTJB02.
        /// </summary>
        public const string JBURDTJB02 = "JBURDTJB02";

        /// <summary>
        /// JBURDTJB03.
        /// </summary>
        public const string JBURDTJB03 = "JBURDTJB03";

        /// <summary>
        /// JBURDTJB04.
        /// </summary>
        public const string JBURDTJB04 = "JBURDTJB04";

        /// <summary>
        /// JBURDTJB05.
        /// </summary>
        public const string JBURDTJB05 = "JBURDTJB05";

        /// <summary>
        /// JBJVOST1.
        /// </summary>
        public const string JBJVOST1 = "JBJVOST1";

        /// <summary>
        /// JBJVOST2.
        /// </summary>
        public const string JBJVOST2 = "JBJVOST2";

        /// <summary>
        /// JBJVOST3.
        /// </summary>
        public const string JBJVOST3 = "JBJVOST3";

        /// <summary>
        /// JBJVODT1.
        /// </summary>
        public const string JBJVODT1 = "JBJVODT1";

        /// <summary>
        /// JBJVODT2.
        /// </summary>
        public const string JBJVODT2 = "JBJVODT2";

        /// <summary>
        /// JBJVODT3.
        /// </summary>
        public const string JBJVODT3 = "JBJVODT3";

        /// <summary>
        /// JBJVONU1.
        /// </summary>
        public const string JBJVONU1 = "JBJVONU1";

        /// <summary>
        /// JBJVONU2.
        /// </summary>
        public const string JBJVONU2 = "JBJVONU2";

        /// <summary>
        /// JBJVONU3.
        /// </summary>
        public const string JBJVONU3 = "JBJVONU3";

        /// <summary>
        /// JBJVOCH1.
        /// </summary>
        public const string JBJVOCH1 = "JBJVOCH1";

        /// <summary>
        /// JBJVOCH2.
        /// </summary>
        public const string JBJVOCH2 = "JBJVOCH2";

        /// <summary>
        /// JBJVOCH3.
        /// </summary>
        public const string JBJVOCH3 = "JBJVOCH3";
    }

    /// <inheritdoc />
    public override string TableName => "F09J0006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JBCO", "JBCO", JdeDataType.String, 10),
        new JdeField("JBMCUS", "JBMCUS", JdeDataType.String, 24),
        new JdeField("JBMCU", "JBMCU", JdeDataType.String, 24, true, true),
        new JdeField("JBJVRMCU", "JBJVRMCU", JdeDataType.String, 24),
        new JdeField("JBJVRMK", "JBJVRMK", JdeDataType.String, 160),
        new JdeField("JBJVANOV", "JBJVANOV", JdeDataType.String, 2),
        new JdeField("JBJVCOH", "JBJVCOH", JdeDataType.String, 2),
        new JdeField("JBJVINDATE", "JBJVINDATE", JdeDataType.Numeric),
        new JdeField("JBTORG", "JBTORG", JdeDataType.String, 20),
        new JdeField("JBENTJ", "JBENTJ", JdeDataType.Numeric),
        new JdeField("JBUSER", "JBUSER", JdeDataType.String, 20),
        new JdeField("JBMKEY", "JBMKEY", JdeDataType.String, 30),
        new JdeField("JBPID", "JBPID", JdeDataType.String, 20),
        new JdeField("JBUPMJ", "JBUPMJ", JdeDataType.Numeric),
        new JdeField("JBUPMT", "JBUPMT", JdeDataType.Numeric),
        new JdeField("JBURNUMB01", "JBURNUMB01", JdeDataType.Numeric),
        new JdeField("JBURNUMB02", "JBURNUMB02", JdeDataType.Numeric),
        new JdeField("JBURNUMB03", "JBURNUMB03", JdeDataType.Numeric),
        new JdeField("JBURNUMB04", "JBURNUMB04", JdeDataType.Numeric),
        new JdeField("JBURNUMB05", "JBURNUMB05", JdeDataType.Numeric),
        new JdeField("JBURATJB01", "JBURATJB01", JdeDataType.Numeric),
        new JdeField("JBURATJB02", "JBURATJB02", JdeDataType.Numeric),
        new JdeField("JBURATJB03", "JBURATJB03", JdeDataType.Numeric),
        new JdeField("JBURATJB04", "JBURATJB04", JdeDataType.Numeric),
        new JdeField("JBURATJB05", "JBURATJB05", JdeDataType.Numeric),
        new JdeField("JBURCDJB01", "JBURCDJB01", JdeDataType.String, 4),
        new JdeField("JBURCDJB02", "JBURCDJB02", JdeDataType.String, 4),
        new JdeField("JBURCDJB03", "JBURCDJB03", JdeDataType.String, 4),
        new JdeField("JBURCDJB04", "JBURCDJB04", JdeDataType.String, 4),
        new JdeField("JBURCDJB05", "JBURCDJB05", JdeDataType.String, 4),
        new JdeField("JBURRFJB01", "JBURRFJB01", JdeDataType.String, 30),
        new JdeField("JBURRFJB02", "JBURRFJB02", JdeDataType.String, 30),
        new JdeField("JBURRFJB03", "JBURRFJB03", JdeDataType.String, 30),
        new JdeField("JBURRFJB04", "JBURRFJB04", JdeDataType.String, 30),
        new JdeField("JBURRFJB05", "JBURRFJB05", JdeDataType.String, 30),
        new JdeField("JBURSTJB01", "JBURSTJB01", JdeDataType.String, 160),
        new JdeField("JBURSTJB02", "JBURSTJB02", JdeDataType.String, 160),
        new JdeField("JBURSTJB03", "JBURSTJB03", JdeDataType.String, 160),
        new JdeField("JBURSTJB04", "JBURSTJB04", JdeDataType.String, 160),
        new JdeField("JBURSTJB05", "JBURSTJB05", JdeDataType.String, 160),
        new JdeField("JBURDTJB01", "JBURDTJB01", JdeDataType.Numeric),
        new JdeField("JBURDTJB02", "JBURDTJB02", JdeDataType.Numeric),
        new JdeField("JBURDTJB03", "JBURDTJB03", JdeDataType.Numeric),
        new JdeField("JBURDTJB04", "JBURDTJB04", JdeDataType.Numeric),
        new JdeField("JBURDTJB05", "JBURDTJB05", JdeDataType.Numeric),
        new JdeField("JBJVOST1", "JBJVOST1", JdeDataType.String, 160),
        new JdeField("JBJVOST2", "JBJVOST2", JdeDataType.String, 160),
        new JdeField("JBJVOST3", "JBJVOST3", JdeDataType.String, 160),
        new JdeField("JBJVODT1", "JBJVODT1", JdeDataType.Numeric),
        new JdeField("JBJVODT2", "JBJVODT2", JdeDataType.Numeric),
        new JdeField("JBJVODT3", "JBJVODT3", JdeDataType.Numeric),
        new JdeField("JBJVONU1", "JBJVONU1", JdeDataType.Numeric),
        new JdeField("JBJVONU2", "JBJVONU2", JdeDataType.Numeric),
        new JdeField("JBJVONU3", "JBJVONU3", JdeDataType.Numeric),
        new JdeField("JBJVOCH1", "JBJVOCH1", JdeDataType.String, 2),
        new JdeField("JBJVOCH2", "JBJVOCH2", JdeDataType.String, 2),
        new JdeField("JBJVOCH3", "JBJVOCH3", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J0006_0", "Primary Key on JBMCU", new[] { "JBMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
