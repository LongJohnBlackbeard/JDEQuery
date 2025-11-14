using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07620 - .
/// </summary>
public class F07620 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LVAN8.
        /// </summary>
        public const string LVAN8 = "LVAN8";

        /// <summary>
        /// LVRKID.
        /// </summary>
        public const string LVRKID = "LVRKID";

        /// <summary>
        /// LVLNID.
        /// </summary>
        public const string LVLNID = "LVLNID";

        /// <summary>
        /// LVPRTR.
        /// </summary>
        public const string LVPRTR = "LVPRTR";

        /// <summary>
        /// LVLVST.
        /// </summary>
        public const string LVLVST = "LVLVST";

        /// <summary>
        /// LVLRDT.
        /// </summary>
        public const string LVLRDT = "LVLRDT";

        /// <summary>
        /// LVLTTP.
        /// </summary>
        public const string LVLTTP = "LVLTTP";

        /// <summary>
        /// LVLVBD.
        /// </summary>
        public const string LVLVBD = "LVLVBD";

        /// <summary>
        /// LVLVED.
        /// </summary>
        public const string LVLVED = "LVLVED";

        /// <summary>
        /// LVDW.
        /// </summary>
        public const string LVDW = "LVDW";

        /// <summary>
        /// LVLDUR.
        /// </summary>
        public const string LVLDUR = "LVLDUR";

        /// <summary>
        /// LVLVSP.
        /// </summary>
        public const string LVLVSP = "LVLVSP";

        /// <summary>
        /// LVFACA.
        /// </summary>
        public const string LVFACA = "LVFACA";

        /// <summary>
        /// LVLVTK.
        /// </summary>
        public const string LVLVTK = "LVLVTK";

        /// <summary>
        /// LVLVRM.
        /// </summary>
        public const string LVLVRM = "LVLVRM";

        /// <summary>
        /// LVRQCP.
        /// </summary>
        public const string LVRQCP = "LVRQCP";

        /// <summary>
        /// LVUSER.
        /// </summary>
        public const string LVUSER = "LVUSER";

        /// <summary>
        /// LVPID.
        /// </summary>
        public const string LVPID = "LVPID";

        /// <summary>
        /// LVJOBN.
        /// </summary>
        public const string LVJOBN = "LVJOBN";

        /// <summary>
        /// LVUPMJ.
        /// </summary>
        public const string LVUPMJ = "LVUPMJ";

        /// <summary>
        /// LVUPMT.
        /// </summary>
        public const string LVUPMT = "LVUPMT";

        /// <summary>
        /// LVSCTR.
        /// </summary>
        public const string LVSCTR = "LVSCTR";

        /// <summary>
        /// LVSCRX.
        /// </summary>
        public const string LVSCRX = "LVSCRX";

        /// <summary>
        /// LVSVH.
        /// </summary>
        public const string LVSVH = "LVSVH";

        /// <summary>
        /// LVPAYLIA.
        /// </summary>
        public const string LVPAYLIA = "LVPAYLIA";
    }

    /// <inheritdoc />
    public override string TableName => "F07620";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LVAN8", "LVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LVRKID", "LVRKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LVLNID", "LVLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("LVPRTR", "LVPRTR", JdeDataType.Numeric),
        new JdeField("LVLVST", "LVLVST", JdeDataType.String, 2, true, true),
        new JdeField("LVLRDT", "LVLRDT", JdeDataType.Numeric),
        new JdeField("LVLTTP", "LVLTTP", JdeDataType.String, 4),
        new JdeField("LVLVBD", "LVLVBD", JdeDataType.Numeric),
        new JdeField("LVLVED", "LVLVED", JdeDataType.Numeric),
        new JdeField("LVDW", "LVDW", JdeDataType.String, 2),
        new JdeField("LVLDUR", "LVLDUR", JdeDataType.Numeric),
        new JdeField("LVLVSP", "LVLVSP", JdeDataType.Numeric),
        new JdeField("LVFACA", "LVFACA", JdeDataType.Numeric),
        new JdeField("LVLVTK", "LVLVTK", JdeDataType.Numeric),
        new JdeField("LVLVRM", "LVLVRM", JdeDataType.Numeric),
        new JdeField("LVRQCP", "LVRQCP", JdeDataType.String, 2),
        new JdeField("LVUSER", "LVUSER", JdeDataType.String, 20),
        new JdeField("LVPID", "LVPID", JdeDataType.String, 20),
        new JdeField("LVJOBN", "LVJOBN", JdeDataType.String, 20),
        new JdeField("LVUPMJ", "LVUPMJ", JdeDataType.Numeric),
        new JdeField("LVUPMT", "LVUPMT", JdeDataType.Numeric),
        new JdeField("LVSCTR", "LVSCTR", JdeDataType.String, 2),
        new JdeField("LVSCRX", "LVSCRX", JdeDataType.String, 2),
        new JdeField("LVSVH", "LVSVH", JdeDataType.String, 2),
        new JdeField("LVPAYLIA", "LVPAYLIA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07620_0", "Primary Key on LVAN8, LVRKID, LVLVST, LVLNID", new[] { "LVAN8", "LVRKID", "LVLVST", "LVLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07620_2", "Index on LVAN8, LVPRTR", new[] { "LVAN8", "LVPRTR" }),
        new JdeIndex("F07620_3", "Index on LVAN8, LVRKID, LVLVBD", new[] { "LVAN8", "LVRKID", "LVLVBD" }),
        new JdeIndex("F07620_4", "Index on LVAN8, LVRKID, LVPRTR", new[] { "LVAN8", "LVRKID", "LVPRTR" }),
        new JdeIndex("F07620_5", "Index on LVLTTP", new[] { "LVLTTP" }),
        new JdeIndex("F07620_6", "Index on LVAN8, LVLVBD, LVLTTP", new[] { "LVAN8", "LVLVBD", "LVLTTP" })
    };
}
