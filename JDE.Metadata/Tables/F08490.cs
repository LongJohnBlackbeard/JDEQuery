using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08490 - .
/// </summary>
public class F08490 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RINURC.
        /// </summary>
        public const string RINURC = "RINURC";

        /// <summary>
        /// RIAN8.
        /// </summary>
        public const string RIAN8 = "RIAN8";

        /// <summary>
        /// RIGNNM.
        /// </summary>
        public const string RIGNNM = "RIGNNM";

        /// <summary>
        /// RIMDNM.
        /// </summary>
        public const string RIMDNM = "RIMDNM";

        /// <summary>
        /// RISRNM.
        /// </summary>
        public const string RISRNM = "RISRNM";

        /// <summary>
        /// RIADD1.
        /// </summary>
        public const string RIADD1 = "RIADD1";

        /// <summary>
        /// RIADD2.
        /// </summary>
        public const string RIADD2 = "RIADD2";

        /// <summary>
        /// RIADD3.
        /// </summary>
        public const string RIADD3 = "RIADD3";

        /// <summary>
        /// RIADD4.
        /// </summary>
        public const string RIADD4 = "RIADD4";

        /// <summary>
        /// RICTY1.
        /// </summary>
        public const string RICTY1 = "RICTY1";

        /// <summary>
        /// RIADDS.
        /// </summary>
        public const string RIADDS = "RIADDS";

        /// <summary>
        /// RICOUN.
        /// </summary>
        public const string RICOUN = "RICOUN";

        /// <summary>
        /// RICTR.
        /// </summary>
        public const string RICTR = "RICTR";

        /// <summary>
        /// RIADDZ.
        /// </summary>
        public const string RIADDZ = "RIADDZ";

        /// <summary>
        /// RIAR1.
        /// </summary>
        public const string RIAR1 = "RIAR1";

        /// <summary>
        /// RIPH1.
        /// </summary>
        public const string RIPH1 = "RIPH1";

        /// <summary>
        /// RIPHT1.
        /// </summary>
        public const string RIPHT1 = "RIPHT1";

        /// <summary>
        /// RIAR2.
        /// </summary>
        public const string RIAR2 = "RIAR2";

        /// <summary>
        /// RIPH2.
        /// </summary>
        public const string RIPH2 = "RIPH2";

        /// <summary>
        /// RIPHT2.
        /// </summary>
        public const string RIPHT2 = "RIPHT2";

        /// <summary>
        /// RIEMAL.
        /// </summary>
        public const string RIEMAL = "RIEMAL";

        /// <summary>
        /// RIHM06.
        /// </summary>
        public const string RIHM06 = "RIHM06";

        /// <summary>
        /// RISPYN.
        /// </summary>
        public const string RISPYN = "RISPYN";

        /// <summary>
        /// RIHM05.
        /// </summary>
        public const string RIHM05 = "RIHM05";

        /// <summary>
        /// RITVPC.
        /// </summary>
        public const string RITVPC = "RITVPC";

        /// <summary>
        /// RISHFT.
        /// </summary>
        public const string RISHFT = "RISHFT";

        /// <summary>
        /// RISALA.
        /// </summary>
        public const string RISALA = "RISALA";

        /// <summary>
        /// RIHRA.
        /// </summary>
        public const string RIHRA = "RIHRA";

        /// <summary>
        /// RIHN01.
        /// </summary>
        public const string RIHN01 = "RIHN01";

        /// <summary>
        /// RIHM07.
        /// </summary>
        public const string RIHM07 = "RIHM07";

        /// <summary>
        /// RIINFC.
        /// </summary>
        public const string RIINFC = "RIINFC";

        /// <summary>
        /// RIPID.
        /// </summary>
        public const string RIPID = "RIPID";

        /// <summary>
        /// RIUSER.
        /// </summary>
        public const string RIUSER = "RIUSER";

        /// <summary>
        /// RIMKEY.
        /// </summary>
        public const string RIMKEY = "RIMKEY";

        /// <summary>
        /// RIUPMJ.
        /// </summary>
        public const string RIUPMJ = "RIUPMJ";

        /// <summary>
        /// RIUPMT.
        /// </summary>
        public const string RIUPMT = "RIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08490";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RINURC", "RINURC", JdeDataType.Numeric, null, true, true),
        new JdeField("RIAN8", "RIAN8", JdeDataType.Numeric),
        new JdeField("RIGNNM", "RIGNNM", JdeDataType.String, 50),
        new JdeField("RIMDNM", "RIMDNM", JdeDataType.String, 50),
        new JdeField("RISRNM", "RISRNM", JdeDataType.String, 50),
        new JdeField("RIADD1", "RIADD1", JdeDataType.String, 80),
        new JdeField("RIADD2", "RIADD2", JdeDataType.String, 80),
        new JdeField("RIADD3", "RIADD3", JdeDataType.String, 80),
        new JdeField("RIADD4", "RIADD4", JdeDataType.String, 80),
        new JdeField("RICTY1", "RICTY1", JdeDataType.String, 50),
        new JdeField("RIADDS", "RIADDS", JdeDataType.String, 6),
        new JdeField("RICOUN", "RICOUN", JdeDataType.String, 50),
        new JdeField("RICTR", "RICTR", JdeDataType.String, 6),
        new JdeField("RIADDZ", "RIADDZ", JdeDataType.String, 24),
        new JdeField("RIAR1", "RIAR1", JdeDataType.String, 12),
        new JdeField("RIPH1", "RIPH1", JdeDataType.String, 40),
        new JdeField("RIPHT1", "RIPHT1", JdeDataType.String, 8),
        new JdeField("RIAR2", "RIAR2", JdeDataType.String, 12),
        new JdeField("RIPH2", "RIPH2", JdeDataType.String, 40),
        new JdeField("RIPHT2", "RIPHT2", JdeDataType.String, 8),
        new JdeField("RIEMAL", "RIEMAL", JdeDataType.String, 512),
        new JdeField("RIHM06", "RIHM06", JdeDataType.String, 2),
        new JdeField("RISPYN", "RISPYN", JdeDataType.String, 2),
        new JdeField("RIHM05", "RIHM05", JdeDataType.String, 2),
        new JdeField("RITVPC", "RITVPC", JdeDataType.String, 6),
        new JdeField("RISHFT", "RISHFT", JdeDataType.String, 2),
        new JdeField("RISALA", "RISALA", JdeDataType.Numeric),
        new JdeField("RIHRA", "RIHRA", JdeDataType.Numeric),
        new JdeField("RIHN01", "RIHN01", JdeDataType.String, 6),
        new JdeField("RIHM07", "RIHM07", JdeDataType.String, 2),
        new JdeField("RIINFC", "RIINFC", JdeDataType.String, 2),
        new JdeField("RIPID", "RIPID", JdeDataType.String, 20),
        new JdeField("RIUSER", "RIUSER", JdeDataType.String, 20),
        new JdeField("RIMKEY", "RIMKEY", JdeDataType.String, 30),
        new JdeField("RIUPMJ", "RIUPMJ", JdeDataType.Numeric),
        new JdeField("RIUPMT", "RIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08490_0", "Primary Key on RINURC", new[] { "RINURC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08490_2", "Index on RIAN8", new[] { "RIAN8" })
    };
}
