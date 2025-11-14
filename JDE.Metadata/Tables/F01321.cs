using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01321 - .
/// </summary>
public class F01321 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RMRECURID.
        /// </summary>
        public const string RMRECURID = "RMRECURID";

        /// <summary>
        /// RMRETYP.
        /// </summary>
        public const string RMRETYP = "RMRETYP";

        /// <summary>
        /// RMTDSTR.
        /// </summary>
        public const string RMTDSTR = "RMTDSTR";

        /// <summary>
        /// RMTDEND.
        /// </summary>
        public const string RMTDEND = "RMTDEND";

        /// <summary>
        /// RMDOWK.
        /// </summary>
        public const string RMDOWK = "RMDOWK";

        /// <summary>
        /// RMFRQCY.
        /// </summary>
        public const string RMFRQCY = "RMFRQCY";

        /// <summary>
        /// RMWOMTH.
        /// </summary>
        public const string RMWOMTH = "RMWOMTH";

        /// <summary>
        /// RMURCH.
        /// </summary>
        public const string RMURCH = "RMURCH";

        /// <summary>
        /// RMURNUM.
        /// </summary>
        public const string RMURNUM = "RMURNUM";

        /// <summary>
        /// RMURTIME.
        /// </summary>
        public const string RMURTIME = "RMURTIME";

        /// <summary>
        /// RMUDTTM.
        /// </summary>
        public const string RMUDTTM = "RMUDTTM";

        /// <summary>
        /// RMUSER.
        /// </summary>
        public const string RMUSER = "RMUSER";

        /// <summary>
        /// RMEDATE.
        /// </summary>
        public const string RMEDATE = "RMEDATE";

        /// <summary>
        /// RMMKEY.
        /// </summary>
        public const string RMMKEY = "RMMKEY";

        /// <summary>
        /// RMENTDBY.
        /// </summary>
        public const string RMENTDBY = "RMENTDBY";
    }

    /// <inheritdoc />
    public override string TableName => "F01321";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RMRECURID", "RMRECURID", JdeDataType.String, 72, true, true),
        new JdeField("RMRETYP", "RMRETYP", JdeDataType.String, 100),
        new JdeField("RMTDSTR", "RMTDSTR", JdeDataType.Date),
        new JdeField("RMTDEND", "RMTDEND", JdeDataType.Date),
        new JdeField("RMDOWK", "RMDOWK", JdeDataType.String, 14),
        new JdeField("RMFRQCY", "RMFRQCY", JdeDataType.Numeric),
        new JdeField("RMWOMTH", "RMWOMTH", JdeDataType.String, 10),
        new JdeField("RMURCH", "RMURCH", JdeDataType.String, 100),
        new JdeField("RMURNUM", "RMURNUM", JdeDataType.Numeric),
        new JdeField("RMURTIME", "RMURTIME", JdeDataType.Date),
        new JdeField("RMUDTTM", "RMUDTTM", JdeDataType.Date),
        new JdeField("RMUSER", "RMUSER", JdeDataType.String, 20),
        new JdeField("RMEDATE", "RMEDATE", JdeDataType.Date),
        new JdeField("RMMKEY", "RMMKEY", JdeDataType.String, 30),
        new JdeField("RMENTDBY", "RMENTDBY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01321_0", "Primary Key on RMRECURID", new[] { "RMRECURID" }, isUnique: true, isPrimaryKey: true)
    };
}
