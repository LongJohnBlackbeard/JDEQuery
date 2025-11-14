using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G81 - .
/// </summary>
public class F52G81 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHIPSTYLE.
        /// </summary>
        public const string SHIPSTYLE = "SHIPSTYLE";

        /// <summary>
        /// SHDL01.
        /// </summary>
        public const string SHDL01 = "SHDL01";

        /// <summary>
        /// SHPRLVL.
        /// </summary>
        public const string SHPRLVL = "SHPRLVL";

        /// <summary>
        /// SHPRNTCUM.
        /// </summary>
        public const string SHPRNTCUM = "SHPRNTCUM";

        /// <summary>
        /// SHPRPOP.
        /// </summary>
        public const string SHPRPOP = "SHPRPOP";

        /// <summary>
        /// SHPRFND.
        /// </summary>
        public const string SHPRFND = "SHPRFND";

        /// <summary>
        /// SHPRAWD.
        /// </summary>
        public const string SHPRAWD = "SHPRAWD";

        /// <summary>
        /// SHSTLOPT01.
        /// </summary>
        public const string SHSTLOPT01 = "SHSTLOPT01";

        /// <summary>
        /// SHSTLOPT02.
        /// </summary>
        public const string SHSTLOPT02 = "SHSTLOPT02";

        /// <summary>
        /// SHSTLOPT03.
        /// </summary>
        public const string SHSTLOPT03 = "SHSTLOPT03";

        /// <summary>
        /// SHSTLOPT04.
        /// </summary>
        public const string SHSTLOPT04 = "SHSTLOPT04";

        /// <summary>
        /// SHSTLOPT05.
        /// </summary>
        public const string SHSTLOPT05 = "SHSTLOPT05";

        /// <summary>
        /// SHSTLOPT06.
        /// </summary>
        public const string SHSTLOPT06 = "SHSTLOPT06";

        /// <summary>
        /// SHSTLOPT07.
        /// </summary>
        public const string SHSTLOPT07 = "SHSTLOPT07";

        /// <summary>
        /// SHSTLOPT08.
        /// </summary>
        public const string SHSTLOPT08 = "SHSTLOPT08";

        /// <summary>
        /// SHSTLOPT09.
        /// </summary>
        public const string SHSTLOPT09 = "SHSTLOPT09";

        /// <summary>
        /// SHSTLOPT10.
        /// </summary>
        public const string SHSTLOPT10 = "SHSTLOPT10";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHMKEY.
        /// </summary>
        public const string SHMKEY = "SHMKEY";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHUPMT.
        /// </summary>
        public const string SHUPMT = "SHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G81";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHIPSTYLE", "SHIPSTYLE", JdeDataType.String, 20, true, true),
        new JdeField("SHDL01", "SHDL01", JdeDataType.String, 60),
        new JdeField("SHPRLVL", "SHPRLVL", JdeDataType.String, 2),
        new JdeField("SHPRNTCUM", "SHPRNTCUM", JdeDataType.String, 2),
        new JdeField("SHPRPOP", "SHPRPOP", JdeDataType.String, 2),
        new JdeField("SHPRFND", "SHPRFND", JdeDataType.String, 2),
        new JdeField("SHPRAWD", "SHPRAWD", JdeDataType.String, 2),
        new JdeField("SHSTLOPT01", "SHSTLOPT01", JdeDataType.String, 4),
        new JdeField("SHSTLOPT02", "SHSTLOPT02", JdeDataType.String, 4),
        new JdeField("SHSTLOPT03", "SHSTLOPT03", JdeDataType.String, 4),
        new JdeField("SHSTLOPT04", "SHSTLOPT04", JdeDataType.String, 4),
        new JdeField("SHSTLOPT05", "SHSTLOPT05", JdeDataType.String, 4),
        new JdeField("SHSTLOPT06", "SHSTLOPT06", JdeDataType.String, 4),
        new JdeField("SHSTLOPT07", "SHSTLOPT07", JdeDataType.String, 4),
        new JdeField("SHSTLOPT08", "SHSTLOPT08", JdeDataType.String, 4),
        new JdeField("SHSTLOPT09", "SHSTLOPT09", JdeDataType.String, 4),
        new JdeField("SHSTLOPT10", "SHSTLOPT10", JdeDataType.String, 4),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHMKEY", "SHMKEY", JdeDataType.String, 30),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHUPMT", "SHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G81_0", "Primary Key on SHIPSTYLE", new[] { "SHIPSTYLE" }, isUnique: true, isPrimaryKey: true)
    };
}
